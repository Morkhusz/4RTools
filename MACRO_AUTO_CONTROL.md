# Automatic Macro Control Documentation

## Overview
This feature implements automatic control of macros based on game state changes, specifically:
1. **City Enter/Exit Detection**: Automatically disable/enable macros when entering or leaving cities
2. **Chat Message Detection**: Automatically disable macros when receiving chat messages (PM)
3. **@go Command Detection**: Detect teleportation commands and respond accordingly

## Implementation Details

### Architecture
- **MacroAutoController**: Main controller class that monitors game state
- **MacroAutoControllerSingleton**: Singleton pattern for global access
- **MessageCode Extensions**: New message codes for CITY_ENTERED, CITY_EXITED, CHAT_MESSAGE_RECEIVED
- **UserPreferences Extensions**: Persistent storage for auto-control settings
- **MacroAutoSettingsForm**: UI for configuring automatic features

### Detection Methods

#### City Detection (`DetectCityState`)
The system uses multiple indicators to detect if the player is in a city:

1. **Healing Patterns**: Monitors rapid HP/SP regeneration typical of safe zones
2. **Full Health Status**: Checks if HP and SP are at maximum values
3. **Status Buffs**: Looks for city-specific status effects
4. **Combat Activity**: Tracks periods without combat activity

**Current Implementation**:
```csharp
// Enhanced detection using multiple heuristics
bool rapidHealing = /* HP/SP gain detection */;
bool atFullHealth = (currentHp == maxHp && currentSp == maxSp);
bool hasSafeZoneBuff = CheckForSafeZoneBuffs(roClient);
bool noCombatActivity = /* Extended period without stat changes */;

bool inCity = atFullHealth && (rapidHealing || hasSafeZoneBuff || noCombatActivity);
```

#### Chat Detection (`CheckChatMessages`)
Framework for detecting chat activity:

1. **Window Focus Monitoring**: Detects when game window has focus
2. **@go Command Detection**: Placeholder for monitoring teleportation commands
3. **Chat Input Detection**: Framework for detecting active chat windows

**Extensibility Points**:
- `IsGoCommandDetected()`: Implement @go command monitoring
- `IsChatInputActive()`: Implement PM/chat window detection

### Configuration Options

The system provides three configurable options:

1. **AutoDisableOnCityEnter**: Disable macros when entering cities
2. **AutoEnableOnCityExit**: Enable macros when leaving cities  
3. **AutoDisableOnChatMessage**: Disable macros when receiving chat messages

Settings are stored in `UserPreferences` and persist across application restarts.

### Integration Points

#### Message Flow
1. **MacroAutoController** detects state changes
2. Sends appropriate `MessageCode` via observer pattern
3. **MacroSongForm** and **MacroSwitchForm** receive messages
4. Forms call `Start()` or `Stop()` on respective macro instances

#### Lifecycle Management
- Started/stopped with main application toggle (TURN_ON/TURN_OFF)
- Monitors every 500ms when active
- Handles profile changes automatically

## Customization for Specific Game Clients

### Memory Address Customization
For accurate detection, implement client-specific memory reading:

```csharp
// Example: Read location name from memory
private string ReadCurrentLocation(Client roClient)
{
    // Read map name from specific memory address
    byte[] locationBytes = roClient.PMR.ReadProcessMemory((IntPtr)LOCATION_ADDRESS, 32, out _);
    string location = Encoding.Default.GetString(locationBytes).Trim('\0');
    return location;
}

// Check if location is a city
private bool IsLocationCity(string location)
{
    string[] cities = { "prontera", "geffen", "payon", "alberta", "izlude", "morocc" };
    return cities.Any(city => location.ToLower().Contains(city));
}
```

### Status Effect IDs
Update `CheckForSafeZoneBuffs()` with client-specific status IDs:

```csharp
private bool CheckForSafeZoneBuffs(Client roClient)
{
    // Client-specific status effect IDs for safe zones
    uint[] safeZoneBuffIds = { 0x123, 0x456, 0x789 }; // Replace with actual IDs
    
    for (int i = 0; i < 20; i++)
    {
        uint statusEffect = roClient.CurrentBuffStatusCode(i);
        if (safeZoneBuffIds.Contains(statusEffect))
            return true;
    }
    return false;
}
```

### Chat Command Monitoring
Implement @go command detection:

```csharp
private bool IsGoCommandDetected(Client roClient)
{
    // Monitor chat input buffer for @go commands
    // This requires finding the chat input memory address
    try
    {
        byte[] chatBuffer = roClient.PMR.ReadProcessMemory((IntPtr)CHAT_INPUT_ADDRESS, 256, out _);
        string chatText = Encoding.Default.GetString(chatBuffer).Trim('\0');
        
        return chatText.StartsWith("@go") || chatText.StartsWith("/go");
    }
    catch
    {
        return false;
    }
}
```

## Testing and Validation

### Test Scenarios
1. **City Detection**: 
   - Enter a city manually → macros should disable
   - Leave city → macros should re-enable
   - Use @go command → should trigger city enter detection

2. **Chat Detection**:
   - Receive PM → macros should disable
   - Open chat window → should be detected

3. **Settings Persistence**:
   - Change settings → restart application → settings should persist
   - Switch profiles → settings should load per profile

### Debug Output
Monitor console output for debugging:
```
[MacroAutoController] Error in monitoring: ...
[MacroAutoController] Error checking city state: ...
[MacroAutoController] Error checking chat messages: ...
```

## Future Enhancements

1. **Enhanced Location Detection**: Read actual map names from memory
2. **Combat State Monitoring**: Detect when player is in combat
3. **Party/Guild Chat Integration**: Different behavior for different chat types
4. **Teleportation Detection**: Monitor for warp/teleport animations
5. **PvP Zone Detection**: Special handling for PvP areas
6. **Idle Detection**: Auto-enable macros after idle periods

## Troubleshooting

### Common Issues
1. **False Positives**: City detection triggering in non-cities
   - Adjust `atFullHealth` logic
   - Calibrate status buff IDs
   - Increase detection threshold

2. **Missed Detections**: Not detecting city entry/exit
   - Lower detection requirements
   - Add more detection methods
   - Check memory addresses

3. **Performance Issues**: High CPU usage
   - Increase monitoring interval (currently 500ms)
   - Optimize memory reading operations
   - Add detection enable/disable options

### Configuration Tuning
```csharp
// Adjust these values in MacroAutoController:
Thread.Sleep(500); // Monitoring frequency
(DateTime.Now - lastStatusChange).TotalSeconds > 10 // Combat detection threshold
hpGain > maxHp * 0.1 // Healing detection sensitivity
```