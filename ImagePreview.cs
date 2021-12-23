using System.Windows.Forms;

namespace ClipboardHistory
{
    public partial class ImagePreview : Form
    {
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }
        public ImagePreview()
        {
            InitializeComponent();
        }
    }
}
