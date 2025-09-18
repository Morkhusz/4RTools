using System;
using System.Windows.Forms;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class CustomForm : Form, IObserver
    {
        private Subject subject;

        public CustomForm(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROCESS_CHANGED:
                case MessageCode.PROFILE_CHANGED:
                    // Handle updates when process or profile changes
                    break;
                case MessageCode.TURN_ON:
                    // Handle application turn on
                    break;
                case MessageCode.TURN_OFF:
                    // Handle application turn off
                    break;
            }
        }
    }
}