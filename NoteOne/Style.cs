using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne
{
    class Style
    {
        private bool boldOn;
        private bool italicOn;
        private bool underlineOn;
        private bool textCentredOn;
        private bool settingOn;

        public Style(bool boldOn, bool italicOn, bool underlineOn, bool textCentredOn, bool settingOn)
        {
            this.boldOn = boldOn;
            this.italicOn = italicOn;
            this.underlineOn = underlineOn;
            this.textCentredOn = textCentredOn;
            this.settingOn = settingOn;
        }
        public bool GetBoldOn()
        {
            return boldOn;
        }
        public bool GetItalicOn()
        {
            return italicOn;
        }
        public bool GetUnderlineOn()
        {
            return underlineOn;
        }
        public bool GetTextCentredOn()
        {
            return textCentredOn;
        }
        public bool GetSettingOn()
        {
            return settingOn;
        }
        public void SetBoldOn(bool boldOn)
        {
            this.boldOn = boldOn;
        }
        public void SetItalicOn(bool italicOn)
        {
            this.italicOn = italicOn;
        }
        public void SetUnderlineOn(bool underlineOn)
        {
            this.underlineOn = underlineOn;
        }
        public void SetTextCentredOn(bool textCentredOn)
        {
            this.textCentredOn = textCentredOn;
        }
        public void SetSettingOn(bool settingOn)
        {
            this.settingOn = settingOn;
        }
    }
}
