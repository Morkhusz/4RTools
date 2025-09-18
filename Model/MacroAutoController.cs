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
        public bool AutoDisableOnCityEnter { get; set; } = true;
        public bool AutoEnableOnCityExit { get; set; } = true;
        public bool AutoDisableOnChatMessage { get; set; } = true;
        
        // State tracking
        private bool wasInCity = false;
        private string lastChatContent = "";
        
        public MacroAutoController(Subject subject)
        {
            this.subject = subject;
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
                // Check if a chat window or PM window is currently active
                // This can be done by monitoring window focus or specific UI elements
                
                // Method 1: Check if game window has focus and detect chat input
                IntPtr foregroundWindow = GetForegroundWindow();
                IntPtr gameWindow = roClient.process.MainWindowHandle;
                
                if (foregroundWindow == gameWindow)
                {
                    // Game window is active, check if chat input is focused
                    // This would require more specific window analysis
                    
                    // Method 2: Check for specific memory addresses that indicate chat state
                    // For now, we'll use a placeholder implementation
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
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        
        private bool DetectCityState(Client roClient)
        {
            // This is a simplified detection method
            // In a real implementation, this would read specific memory addresses
            // that contain location information or detect UI elements specific to cities
            
            try
            {
                uint currentHp = roClient.ReadCurrentHp();
                uint maxHp = roClient.ReadMaxHp();
                uint currentSp = roClient.ReadCurrentSp();
                uint maxSp = roClient.ReadMaxSp();
                
                // Skip detection if values are invalid
                if (currentHp == 0 || maxHp == 0 || currentSp == 0 || maxSp == 0)
                    return wasInCity; // Keep previous state
                
                // Improved heuristic: 
                // 1. HP and SP are both at max (cities heal players)
                // 2. And no recent HP/SP changes (no combat)
                bool atFullHealth = (currentHp == maxHp && currentSp == maxSp);
                
                // Additional check: Look for status effects that might indicate city
                // Status effect at index 0 might be a city-related buff
                uint statusEffect = roClient.CurrentBuffStatusCode(0);
                bool hasUrbanBuff = (statusEffect != 0); // Placeholder for actual city buff detection
                
                // Combine heuristics: full health OR specific city buffs
                return atFullHealth || hasUrbanBuff;
            }
            catch
            {
                return wasInCity; // Keep previous state on error
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