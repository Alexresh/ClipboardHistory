using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardHistory
{
    public partial class MainForm : Form
    {
        readonly ClipboardList manager;
        readonly ImagePreview imagePreviewForm;
        public MainForm()
        {
            InitializeComponent();
            manager = new ClipboardList();
            imagePreviewForm = new();
            Timer checkTimer = new();
            checkTimer.Tick += ClipboardChecker_Tick;
            checkTimer.Interval = 1000;
            checkTimer.Enabled = true;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Opacity = 0;
        }

        private void ClipboardChecker_Tick(Object source, EventArgs e)
        {
            if (Clipboard.ContainsText()) 
            {
                ClipboardText clipboardText = new();
                clipboardText.Pull();
                if (manager.Add(clipboardText)) 
                {
                    if (clipboardText.GetData().ToString().Length > 100)
                    {
                        TextListBox.Items.Insert(0, clipboardText.GetData().ToString().Substring(0, 100));
                    }
                    else
                    {
                        TextListBox.Items.Insert(0, clipboardText.GetData().ToString());
                    }
                }
                return;
            }
            if (Clipboard.ContainsImage()) 
            {
                ClipboardImage clipboardImage = new();
                clipboardImage.Pull();
                if (manager.Add(clipboardImage))
                {
                    TextListBox.Items.Insert(0, "image "+DateTime.Now);
                }
                return;
            }
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            Activate();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Opacity = 0.8;
        }


        async private void TextListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = TextListBox.SelectedIndex;
            ICopyable item = manager.GetById(index);
            if (item is ClipboardImage)
            {
                imagePreviewForm.Show();
                Point cursorPosition = Cursor.Position;
                cursorPosition.Offset(10, 10);
                imagePreviewForm.Location = cursorPosition;
                imagePreviewForm.BackgroundImage = (Image)item.GetData();
                await Task.Delay(1000);
                imagePreviewForm.Hide();
            }
                
        }

        async private void TextListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = TextListBox.SelectedIndex;
            if (manager.PushInClipboard(index))
            {
                string text = TextListBox.SelectedItem.ToString();
                TextListBox.Items[TextListBox.SelectedIndex] = "Скопировано";
                await Task.Delay(2000);
                TextListBox.Items[TextListBox.SelectedIndex] = text;
            }
        }
    }
}
