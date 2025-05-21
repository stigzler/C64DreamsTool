using C64DreamsTool.Properties;
using stigzler.Winforms.Base.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C64DreamsTool
{
    [DefaultEvent("Click")]
    public partial class NavButton : BaseUserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Label
        {
            get { return TextLB.Text; }
            set { TextLB.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get { return ImagePB.BackgroundImage; }
            set { ImagePB.BackgroundImage = value; }
        }

        public NavButton()
        {
            InitializeComponent();
        }

        private void NavButton_Load(object sender, EventArgs e)
        {
            this.DarkModeChanged += NavButton_DarkModeChanged;
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Click += RaiseClick();
            }
        }



        private EventHandler RaiseClick()
        {
            return (sender, e) => OnClick(EventArgs.Empty);
        }

        private void NavButton_DarkModeChanged(object? sender, bool e)
        {
            SetDefaultButtonStyle();
        }

        internal void SetDefaultButtonStyle()
        {
            if (DarkMode)
            {
                BackColor = Settings.Default.DarkButtonBG;
                TextLB.ForeColor = Settings.Default.DarkButtonText;
            }
            else
            {
                BackColor = Settings.Default.LightButtonBG;
                TextLB.ForeColor = Settings.Default.LightButtonText;
            }
            navButtonHighlighted = false;
        }

        bool navButtonHighlighted = false;

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (navButtonHighlighted) return;
            FocusNavButton(this);
            navButtonHighlighted = true;
        }

        internal void FocusNavButton(NavButton sender)
        {
            if (DarkMode)
            {
                BackColor = Services.UiOps.ChangeColorBrightness(BackColor, 0.05f);
                TextLB.ForeColor = Services.UiOps.ChangeColorBrightness(BackColor, 1f);
            }
            else
            {
                BackColor = Services.UiOps.ChangeColorBrightness(BackColor, -0.05f);
                TextLB.ForeColor = Services.UiOps.ChangeColorBrightness(BackColor, -1f);
            }
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            Control childControl = GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (childControl == null || childControl == this)
            {
                SetDefaultButtonStyle();
                navButtonHighlighted = false;
            }        
        }
    }
}
