using System;
using System.Threading;
using System.Text.RegularExpressions;
using _4RTools.Utils;

namespace _4RTools.Model
{
    public sealed class MacroAutoControllerSingleton
    {
        private static MacroAutoController instance;
        
        public static MacroAutoController Instance(Subject subject)
        {
            if (instance == null)
                instance = new MacroAutoController(subject);
            return instance;
        }
        
        public static MacroAutoController GetInstance()
        {
            return instance;
        }
    }
    
    public class MacroAutoController
    {
        private Subject subject;
        private _4RThread monitoringThread;
        private bool isMonitoring = false;
        
        // Configuration flags
        public bool AutoControlEnabled { get; set; } = true;
        public bool AutoDisableOnCityEnter { get; set; } = true;
        public bool AutoEnableOnCityExit { get; set; } = true;
        public bool AutoDisableOnChatMessage { get; set; } = true;
        
        // State tracking
        private bool wasInCity = false;
        private string lastChatContent = "";
        private uint lastHpValue = 0;
        private uint lastSpValue = 0;
        private DateTime lastStatusChange = DateTime.Now;
        
        public MacroAutoController(Subject subject)
        {
            this.subject = subject;
            LoadSettingsFromProfile();
        }
        
        private void LoadSettingsFromProfile()
        {
            try
            {
                var preferences = ProfileSingleton.GetCurrent()?.UserPreferences;
                if (preferences != null)
                {
                    AutoControlEnabled = preferences.AutoControlEnabled;
                    AutoDisableOnCityEnter = preferences.AutoDisableOnCityEnter;
                    AutoEnableOnCityExit = preferences.AutoEnableOnCityExit;
                    AutoDisableOnChatMessage = preferences.AutoDisableOnChatMessage;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MacroAutoController] Error loading settings: {ex.Message}");
                // Use default values if loading fails
            }
        }
        
        public void UpdateSettingsFromProfile()
        {
            LoadSettingsFromProfile();
        }
        
        public void StartMonitoring()
        {
            if (!isMonitoring)
            {
                isMonitoring = true;
                this.monitoringThread = new _4RThread((_) => MonitoringThread());
                _4RThread.Start(this.monitoringThread);
            }
        }
        
        public void StopMonitoring()
        {
            isMonitoring = false;
            _4RThread.Stop(this.monitoringThread);
        }
        
        private int MonitoringThread()
        {
            // Skip monitoring if auto control is disabled
            if (!AutoControlEnabled)
            {
                Thread.Sleep(1000);
                return 0;
            }
            
            Client roClient = ClientSingleton.GetClient();
            if (roClient == null)
            {
                Thread.Sleep(1000);
                return 0;
            }
            
            try
            {
                // Monitor for city changes
                if (AutoDisableOnCityEnter || AutoEnableOnCityExit)
                {
                    CheckCityState(roClient);
                }
                
                // Monitor for chat messages
                if (AutoDisableOnChatMessage)
                {
                    CheckChatMessages(roClient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MacroAutoController] Error in monitoring: {ex.Message}");
            }
            
            Thread.Sleep(500); // Check every 500ms
            return 0;
        }
        
        private void CheckCityState(Client roClient)
        {
            try
            {
                // Read character name to detect if we're still connected
                string characterName = roClient.ReadCharacterName();
                if (string.IsNullOrEmpty(characterName))
                    return;
                
                // For now, we'll use a simple heuristic to detect city state
                // This can be improved with specific memory addresses for location detection
                bool currentlyInCity = DetectCityState(roClient);
                
                if (currentlyInCity && !wasInCity && AutoDisableOnCityEnter)
                {
                    // Just entered a city
                    subject.Notify(new Message(MessageCode.CITY_ENTERED, null));
                    wasInCity = true;
                }
                else if (!currentlyInCity && wasInCity && AutoEnableOnCityExit)
                {
                    // Just left a city
                    subject.Notify(new Message(MessageCode.CITY_EXITED, null));
                    wasInCity = false;
                }
                else
                {
                    wasInCity = currentlyInCity;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MacroAutoController] Error checking city state: {ex.Message}");
            }
        }
        
        private void CheckChatMessages(Client roClient)
        {
            try
            {
                // Enhanced chat detection approach
                
                // Method 1: Monitor for @go commands by checking game window activity
                if (IsGoCommandDetected(roClient))
                {
                    // @go command detected, likely teleporting to city
                    subject.Notify(new Message(MessageCode.CITY_ENTERED, null));
                    return;
                }
                
                // Method 2: Check if a chat window or PM window is currently active
                IntPtr foregroundWindow = GetForegroundWindow();
                IntPtr gameWindow = roClient.process.MainWindowHandle;
                
                if (foregroundWindow == gameWindow)
                {
                    // Game window is active, check if chat input is focused
                    if (IsChatInputActive(roClient))
                    {
                        subject.Notify(new Message(MessageCode.CHAT_MESSAGE_RECEIVED, null));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MacroAutoController] Error checking chat messages: {ex.Message}");
            }
        }
        
        private bool IsGoCommandDetected(Client roClient)
        {
            try
            {
                // This is a placeholder for @go command detection
                // Real implementation would need to:
                // 1. Monitor chat input buffer for "@go" commands
                // 2. Check for teleportation status effects
                // 3. Monitor location changes in memory
                
                // For now, we'll rely on city detection through other means
                return false;
            }
            catch
            {
                return false;
            }
        }
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        
        private bool DetectCityState(Client roClient)
        {
            // Enhanced city detection using multiple indicators
            try
            {
                uint currentHp = roClient.ReadCurrentHp();
                uint maxHp = roClient.ReadMaxHp();
                uint currentSp = roClient.ReadCurrentSp();
                uint maxSp = roClient.ReadMaxSp();
                
                // Skip detection if values are invalid
                if (currentHp == 0 || maxHp == 0 || currentSp == 0 || maxSp == 0)
                    return wasInCity; // Keep previous state
                
                // Detect rapid healing (indicator of city/safe zone)
                bool rapidHealing = false;
                if (lastHpValue > 0 && lastSpValue > 0)
                {
                    uint hpGain = currentHp > lastHpValue ? currentHp - lastHpValue : 0;
                    uint spGain = currentSp > lastSpValue ? currentSp - lastSpValue : 0;
                    
                    // If HP or SP increased significantly in short time, likely in city
                    if ((hpGain > maxHp * 0.1 || spGain > maxSp * 0.1) && 
                        (DateTime.Now - lastStatusChange).TotalSeconds < 5)
                    {
                        rapidHealing = true;
                    }
                }
                
                // Update tracking values
                if (lastHpValue != currentHp || lastSpValue != currentSp)
                {
                    lastHpValue = currentHp;
                    lastSpValue = currentSp;
                    lastStatusChange = DateTime.Now;
                }
                
                // Primary indicator: HP and SP at max
                bool atFullHealth = (currentHp == maxHp && currentSp == maxSp);
                
                // Secondary indicator: check for status effects that indicate safe zones
                // Many cities give specific buffs or have indicators in status array
                bool hasSafeZoneBuff = CheckForSafeZoneBuffs(roClient);
                
                // Tertiary indicator: no combat activity for extended period
                bool noCombatActivity = (DateTime.Now - lastStatusChange).TotalSeconds > 10 && atFullHealth;
                
                // City detection logic: combine multiple indicators
                bool inCity = atFullHealth && (rapidHealing || hasSafeZoneBuff || noCombatActivity);
                
                return inCity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MacroAutoController] Error in city detection: {ex.Message}");
                return wasInCity; // Keep previous state on error
            }
        }
        
        private bool CheckForSafeZoneBuffs(Client roClient)
        {
            try
            {
                // Check common status effect slots for city/safe zone indicators
                // These would need to be calibrated for specific RO clients
                for (int i = 0; i < 10; i++) // Check first 10 status slots
                {
                    uint statusEffect = roClient.CurrentBuffStatusCode(i);
                    
                    // Common safe zone status IDs (these would need to be researched per client)
                    // These are placeholder values that would need actual game-specific IDs
                    if (statusEffect == 0x01 || statusEffect == 0x02 || statusEffect == 0x03)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        
        private bool IsChatInputActive(Client roClient)
        {
            try
            {
                // This is a placeholder for actual chat detection
                // Real implementation would need to:
                // 1. Read memory addresses that track chat window state
                // 2. Monitor for specific UI elements being visible
                // 3. Check for keyboard input focus on chat controls
                
                // For now, return false as we can't implement full chat detection
                // without more specific game client knowledge
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}