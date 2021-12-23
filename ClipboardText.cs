using System.Windows.Forms;

namespace ClipboardHistory
{
    class ClipboardText : ICopyable
    {
        private string _text = "";

        public void Pull()
        {
            if (Clipboard.ContainsText())
            {
                _text = Clipboard.GetText();
            }
        }

        public void Push()
        {
            if (_text != "") 
            {
                Clipboard.SetText(_text);
            }
        }

        public object GetData() 
        {
            return _text;
        }

        public bool Equals(ICopyable obj)
        {
            if (!(obj.GetType() == GetType()))
            {
                return false;
            }
            if (!obj.GetData().Equals(GetData()))
            {
                return false;
            }
            return true;
        }
    }
}
