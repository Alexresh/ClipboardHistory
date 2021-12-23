using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClipboardHistory
{
    class ClipboardImage : ICopyable
    {
        private Image _image = null;
        public bool Equals(ICopyable obj)
        {
            if (obj.GetType() == GetType())
            {
                MemoryStream ms1 = new();
                ((Image)obj.GetData()).Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                byte[] a = ms1.ToArray();
                ms1.Close();
                MemoryStream ms2 = new();
                ((Image)GetData()).Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                byte[] b = ms2.ToArray();
                ms1.Close();
                if (a.SequenceEqual(b)) 
                {
                    return true;
                }
                return false;
            }
            else 
            {
                return false;
            }
        }

        public object GetData()
        {
            return _image;
        }

        public void Pull()
        {
            if (Clipboard.ContainsImage()) 
            {
                _image = Clipboard.GetImage();
            }
        }

        public void Push()
        {
            if (!(_image is null)) 
            {
                Clipboard.SetImage(_image);
            }
        }
    }
}
