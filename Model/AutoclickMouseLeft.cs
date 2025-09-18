using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using _4RTools.Utils;
using Newtonsoft.Json;
using System.Media;

namespace _4RTools.Model
{
    public class AutoclickMouseLeft : Action
    {
        private const string ACTION_NAME = "AutoclickMouseLeft";
        private _4RThread thread;
        
        public Key ToggleKey { get; set; } = Key.None;
        public int ClickDelay { get; set; } = 100;
        public bool IsActive { get; set; } = false;
        public bool AudioFeedback { get; set; } = true;

        public AutoclickMouseLeft()
        {
        }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                if (thread != null) 
                {
                    _4RThread.Stop(this.thread);
                }

                if (ToggleKey != Key.None)
                {
                    Keys toggleKey = (Keys)Enum.Parse(typeof(Keys), ToggleKey.ToString());
                    KeyboardHook.AddKeyDown(toggleKey, () => { ToggleActive(); return true; });
                }


                this.thread = new _4RThread(_ => AutoclickThreadExecution(roClient));
                _4RThread.Start(this.thread);
            }
        }

        private int AutoclickThreadExecution(Client roClient)
        {
            // Perform autoclick if active
            if (IsActive && roClient != null)
            {
                // Send left mouse button down and up messages
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                Thread.Sleep(1);
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                
                Thread.Sleep(ClickDelay);
            }
            else
            {
                Thread.Sleep(50); // Small sleep when not active to reduce CPU usage
            }

            return 0;
        }

        public void ToggleActive()
        {
            IsActive = !IsActive;
            
            // Play audio feedback
            if (AudioFeedback)
            {
                if (IsActive)
                {
                    new SoundPlayer(Resources._4RTools.ETCResource.Speech_On).Play();
                }
                else
                {
                    new SoundPlayer(Resources._4RTools.ETCResource.Speech_Off).Play();
                }
            }
        }

        public void Stop()
        {
            IsActive = false;
            
            // Unregister the toggle key if set
            if (ToggleKey != Key.None)
            {
                Keys toggleKey = (Keys)Enum.Parse(typeof(Keys), ToggleKey.ToString());
                KeyboardHook.RemoveDown(toggleKey);
            }
            
            _4RThread.Stop(this.thread);
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return ACTION_NAME;
        }
    }
}