using stigzler.Winforms.Base.Forms.BaseForm;

namespace C64DreamsTool
{
    public partial class Main : BaseForm
    {
        private int navBarTransitionPixelChange = -4;
        private int navBarMinWidth = 52; // must have a factor of 4
        private int navBarMaxWidth = 168; // must have a factor of 4

        public Main()
        {
            InitializeComponent();
        }

        private void DarkLightModeBT_Click(object sender, EventArgs e)
        {
            if (DarkMode) DarkLightModeBT.BackgroundImage = Properties.Resources.DarkMode;
            else DarkLightModeBT.BackgroundImage = Properties.Resources.LightMode;
            DarkMode = !DarkMode;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainTC.HideBorders = true;
            MainTC.HideTabs = true;
            NavBarPN.Width = navBarMaxWidth;

            RefreshImportButtons();

            LaunchboxFBD.Path = Properties.Settings.Default.LaunchboxRootPath;
            C64DreamsFBD.Path = Properties.Settings.Default.C64DreamsRootPath;
        }

        private void navBarTicker_Tick(object sender, EventArgs e)
        {
            NavBarPN.Width += navBarTransitionPixelChange;
            if (NavBarPN.Width <= navBarMinWidth)
            {
                navBarTransitionPixelChange = -navBarTransitionPixelChange;
                navBarTicker.Stop();
            }
            else if (NavBarPN.Width >= navBarMaxWidth)
            {
                navBarTransitionPixelChange = -navBarTransitionPixelChange;
                navBarTicker.Stop();
            }
        }

        private void NavBarBT_Click(object sender, EventArgs e)
        {
            navBarTicker.Start();
        }



        private void NavInstallBT_Click(object sender, EventArgs e)
        {
            MainTC.SelectedTab = InstallTP;
            FocusNavButton(sender as NavButton);
        }

        private void NavSettingsBT_Click(object sender, EventArgs e)
        {
            MainTC.SelectedTab = SettingsTP;
            FocusNavButton(sender as NavButton);
        }



        private void LaunchboxRootFB_PathChanged(stigzler.Winforms.Base.Events.FileSystemObjectChangedEventArgs e)
        {
            TestLbPath(e.OldPath);
        }

        private bool TestLbPath(string oldpath = null)
        {
            if (Services.FileObjectTests.IsLaunchboxRoot(LaunchboxFBD.Path) == false)
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox("The path selected for launchbox does not contain Launchbox.exe or the" +
                " Directory 'Core' meaning this is likely an incorrect path. Please review", "Launchbox Root Path incorrect.",
                MessageBoxButtons.OK, MessageBoxIcon.Error, "Invalid Directory", DarkMode,
                stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog();

                if (oldpath != null) LaunchboxFBD.Path = oldpath;
                return false;
            }
            else
            {
                Properties.Settings.Default.LaunchboxRootPath = LaunchboxFBD.Path;
                Properties.Settings.Default.ValidLbPath = true;
                Properties.Settings.Default.Save();
                RefreshImportButtons();
            }
            return true;
        }

        private bool TestC64DreamsPath(string oldpath = null)
        {
            if (Services.FileObjectTests.IsC64DreamsRoot(C64DreamsFBD.Path) == false)
            {
                //stigzler.Winforms.Base.Forms.MessageBox messageBox =
                //    new stigzler.Winforms.Base.Forms.MessageBox("The selected folder for C64Dreams is not named 'C64 Dreams'" +
                //    " or does not contain an additoinal sub-folder called 'C64 Dreams'. It's a bit confusing, because of the nested 'C64 Dreams' folders. Try setting to a folder that also contains the folders '7-zip', 'Core' and 'Plugins'. Please review.", "C64Dreams Root Path incorrect.",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, "Incorrect Directory Path");

                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                            "The selected folder for C64Dreams is not named 'C64 Dreams'  or does not contain an additional sub-folder called 'C64 Dreams'. It's a bit confusing, because of the nested 'C64 Dreams' folders. Try setting to a folder that also contains the folders '7-zip', 'Core' and 'Plugins'.",
                            "C64Dreams Root Path incorrect.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, "Invalid Directory", DarkMode,
                            stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog();


                //MessageBox.Show("The selected folder for C64Dreams is not named 'C64 Dreams'" +
                //    " or does not contain an additoinal sub-folder called 'C64 Dreams'. It's a bit confusing, because of the nested 'C64 Dreams' folders. Try setting to a folder that also contains the folders '7-zip', 'Core' and 'Plugins'. Please review.", "C64Dreams Root Path incorrect.",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (oldpath != null) C64DreamsFBD.Path = oldpath;
                return false;
            }
            else
            {
                Properties.Settings.Default.C64DreamsRootPath = C64DreamsFBD.Path;
                Properties.Settings.Default.ValidC64dPath = true;
                Properties.Settings.Default.Save();
                RefreshImportButtons();
            }
            return true;
        }

        private void C64DreamsFBD_PathChanged(stigzler.Winforms.Base.Events.FileSystemObjectChangedEventArgs e)
        {
            TestC64DreamsPath(e.OldPath);
        }

        private void RefreshImportButtons()
        {
            if (Properties.Settings.Default.ValidC64dPath && Properties.Settings.Default.ValidLbPath)
            {
                InstallButtonsFLP.Enabled = true;
                PathsWarningLB.Visible = false;
                InstallPN.Visible = true;
            }
            else
            {
                InstallButtonsFLP.Enabled = false;
                PathsWarningLB.Visible = true;
                InstallPN.Visible = false;
            }
        }

        private void FocusNavButton(NavButton clickedNavButton)
        {
            foreach (NavButton navButton in NavBarPN.Controls.OfType<NavButton>())
            {
                if (navButton != clickedNavButton)
                {
                    navButton.SetDefaultButtonStyle();
                }
            }
        }

    }
}
