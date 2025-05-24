using C64DreamsTool.Data;
using C64DreamsTool.Data.Entities;
using C64DreamsTool.Properties;
using C64DreamsTool.Services;
using stigzler.Utilities.Base.BaseEventArgs;
using stigzler.Winforms.Base.Forms.BaseForm;
using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace C64DreamsTool
{
    public partial class Main : BaseForm
    {

        Game addGame = new Game();

        private int navBarMaxWidth = 168;
        private int navBarMinWidth = 52;
        private int navBarTransitionPixelChange = -4;
        // must have a factor of 4
        // must have a factor of 4

        private bool operationRunning = false;
        public Main()
        {
            InitializeComponent();
        }

        private void ApplyHotfix(string version)
        {
            if (!OperationCanBeRun()) { return; }

            switch (version)
            {
                case "0.60.2":
                    stigzler.Winforms.Base.Dialogs.FolderBrowserDialog fbd = new stigzler.Winforms.Base.Dialogs.FolderBrowserDialog();
                    fbd.Description = "Please select the unzipped folder \"C64 Dreams v0.60 Hotfix 6-5-2023\"";
                    var result = fbd.ShowDialog(this);
                    if (result != true) return;
                    if (!Services.FileObjectTests.IsHotfix0602(fbd.SelectedPath))
                    {

                        stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                            "This appears to be the wrong folder for this hotfix. Please ensure that it is unzipped and the root folder.",
                            "Hotfix Root Path incorrect.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, "Invalid Directory", DarkMode,
                            stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                        messageBox.ShowDialog(this);
                        return;

                        //new stigzler.Winforms.Base.Forms.MessageBox("This appears to be the wrong folder for this hotfix. Please ensure that it is unzipped and the root folder.", "Hotfix Root Path incorrect.",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Error, "Incorrect Hotfix Path").ShowDialog();
                        //return;
                    }

                    operationRunning = true;
                    Log("Running Hotfix import.");
                    var hotfixResult = ImportC64Dreams.ImportHotfix(Properties.Settings.Default.LaunchboxRootPath, fbd.SelectedPath);

                    if (hotfixResult == null)
                    {
                        Log(@"Hotfix installed successfully. \o/");
                        Settings.Default.HotfixInstalled = true;
                        RefereshInstallationStatus();
                    }
                    else
                    {
                        Log(@"Hotfix installation unsuccesfull. :^(");
                    }

                    OperationOutcomePrompt(hotfixResult, "Import Successful", $"Hotfix {version} import successful!",
                            "Hotfix import Unsuccessful", "Hotfix import unsuccessful. Error: ");

                    operationRunning = false;

                    break;
            }
        }

        private void C64DreamsFBD_PathChanged(stigzler.Winforms.Base.Events.FileSystemObjectChangedEventArgs e)
        {
            TestC64DreamsPath(e.OldPath);
        }

        private void ClearProgress()
        {
            StatusPB.Style = ProgressBarStyle.Continuous;
            StatusPB.Value = 0;
            StatusPrimaryOpLB.Text = "No operation Running";
            StatusSecondaryOpLB.Text = "";
            StatusPrimaryOpLB.Image = Resources.info;
        }

        private void DarkLightModeBT_Click(object sender, EventArgs e)
        {
            if (DarkMode) DarkLightModeBT.BackgroundImage = Properties.Resources.DarkMode;
            else DarkLightModeBT.BackgroundImage = Properties.Resources.LightMode;
            DarkMode = !DarkMode;
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

        private void Import64DBT_Click(object sender, EventArgs e)
        {
            ImportC64DreamsDreams();
        }

        private async void ImportC64DreamsDreams()
        {
            if (!OperationCanBeRun()) return;

            StatusPB.Style = ProgressBarStyle.Marquee;
            StatusPrimaryOpLB.Text = "Initializing..";

            operationRunning = true;
            InstallButtonsFLP.Enabled = false;

            Log("Running C64DreamsImport. Progress reported in the status bar.");
            //Log("Full import report presented at end of process.");

            StatusPrimaryOpLB.Image = Resources.InstallPackage;

            OperationProgressChangedEventArgs eventArgs = new OperationProgressChangedEventArgs();
            Progress<OperationProgressChangedEventArgs> progress = new Progress<OperationProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            Exception ImportResult = await Task.Run(() => ImportC64Dreams.ImportMainLibrary(LaunchboxFBD.Path,
                    C64DreamsFBD.Path, progress, eventArgs));

            OperationOutcomePrompt(ImportResult, "Import Successful", "C64 Dreams import successful!", "Import Unsuccessful",
                                    "C64 Dreams import unsuccessful. Error: ");

            if (ImportResult == null)
            {
                Log(@"C64Dreams package Import completed successfully. \o/");
                Settings.Default.C64DInstalled = true;
                RefereshInstallationStatus();
            }
            else
            {
                Log(@"C64Dreams package Import unsuccessful. :^(");
            }

            ClearProgress();

            operationRunning = false;
            InstallButtonsFLP.Enabled = true;
            progress.ProgressChanged -= Progress_ProgressChanged;

        }

        private void ImportHotfixBT_Click(object sender, EventArgs e)
        {
            ApplyHotfix("0.60.2");
        }

        private async void ImportMagazineModule()
        {
            if (!OperationCanBeRun()) { return; }

            stigzler.Winforms.Base.Dialogs.FolderBrowserDialog fbd = new stigzler.Winforms.Base.Dialogs.FolderBrowserDialog();
            fbd.Description = "Please select the Magazine Module folder 'C64 Dreams - Magazine Module v0.60'";
            var result = fbd.ShowDialog(this);
            if (result != true) return;

            if (!Services.FileObjectTests.IsMagazineModule(fbd.SelectedPath))
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    "This appears to be the wrong folder for this Magazine Module. Please ensure that it is unzipped and the root folder is selected.",
                    "Magazine Module Path incorrect.", MessageBoxButtons.OK, MessageBoxIcon.Warning, "Invalid Directory", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
                return;
            }

            operationRunning = true;
            StatusPrimaryOpLB.Text = "Importing Magazine Module...";
            StatusPrimaryOpLB.Image = Resources.InstallPackage;
            Log("Importing Magazine Module...");

            OperationProgressChangedEventArgs eventArgs = new OperationProgressChangedEventArgs();
            Progress<OperationProgressChangedEventArgs> progress = new Progress<OperationProgressChangedEventArgs>();
            progress.ProgressChanged += Progress_ProgressChanged;

            var magazineModuleResult = await Task.Run(() => ImportC64Dreams.ImportMagazineModule(Properties.Settings.Default.LaunchboxRootPath,
                fbd.SelectedPath, progress, eventArgs));

            OperationOutcomePrompt(magazineModuleResult, "Import Successful", $"Magazine module import successful!",
                "Magazine module import Unsuccessful", "Magazine module import unsuccessful. Error: ");

            if (magazineModuleResult == null)
            {
                Log(@"Magazine Module Import completed successfully. \o/");
                RefereshInstallationStatus();
                Settings.Default.MagsInstalled = true;
            }
            else
            {
                Log(@"Magazine Module Import unsuccessful. :^(");
            }

            ClearProgress();
            operationRunning = false;
            progress.ProgressChanged -= Progress_ProgressChanged;
        }

        private void ImportMagsBT_Click(object sender, EventArgs e)
        {
            ImportMagazineModule();
        }

        private void LaunchboxRootFB_PathChanged(stigzler.Winforms.Base.Events.FileSystemObjectChangedEventArgs e)
        {
            TestLbPath(e.OldPath);
        }

        private void Log(string text, Color? color = null)
        {
            ConsoleRTB.AppendText(text + Environment.NewLine);

            if (color.HasValue)
            {
                ConsoleRTB.SelectionStart = ConsoleRTB.Text.Length;
                ConsoleRTB.ScrollToCaret();
                ConsoleRTB.SelectionColor = color.Value;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NavBarPN.Width > navBarMinWidth)
            {
                Properties.Settings.Default.NavBarCollapsedOnClose = false;
            }
            else
            {
                Properties.Settings.Default.NavBarCollapsedOnClose = true;
            }

            // Add Game
            Properties.Settings.Default.AddGameName = GameNameTB.Text;
            Properties.Settings.Default.AddGameFile = GameFIleFB.Path;
            Properties.Settings.Default.AddGameSid = SidFB.Path;
            Properties.Settings.Default.AddGameManual = ManualFB.Path;
            Properties.Settings.Default.AddGameCustomCmd = CustomCmdTB.Text;
            Properties.Settings.Default.AddGameReview = MagazineFB.Path;
            Properties.Settings.Default.AddGamePageNumber = (int)PageNumberNUM.Value;
            Settings.Default.AddGameDev = DeveloperTB.Text;
            Settings.Default.AddGamePub = PublisherTB.Text;
            Settings.Default.AddGameNotes = NotesTB.Text;
            Settings.Default.Save();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainTC.HideBorders = true;
            MainTC.HideTabs = true;
            NavBarPN.Width = navBarMaxWidth;

            // forget for now - annoyingly sticky
            //if (Properties.Settings.Default.NavBarCollapsedOnClose == true)
            //{
            //    NavBarPN.Width = navBarMinWidth;
            //}
            //else
            //{
            //    NavBarPN.Width = navBarMaxWidth;
            //}

            ReviewUILocks();

            // Populate relevant controls from Settings
            // Settings
            LaunchboxFBD.Path = Properties.Settings.Default.LaunchboxRootPath;
            C64DreamsFBD.Path = Properties.Settings.Default.C64DreamsRootPath;
            GameslistNameTB.Text = Settings.Default.GameslistName;

            // Add Game
            GameNameTB.Text = Properties.Settings.Default.AddGameName;
            GameFIleFB.Path = Properties.Settings.Default.AddGameFile;
            SidFB.Path = Properties.Settings.Default.AddGameSid;
            ManualFB.Path = Properties.Settings.Default.AddGameManual;
            CustomCmdTB.Text = Properties.Settings.Default.AddGameCustomCmd;
            MagazineFB.Path = Properties.Settings.Default.AddGameReview;
            PageNumberNUM.Value = Properties.Settings.Default.AddGamePageNumber;
            DeveloperTB.Text = Settings.Default.AddGameDev;
            PublisherTB.Text = Settings.Default.AddGamePub;
            NotesTB.Text = Settings.Default.AddGameNotes;

            // Images dropdown
            ImagesCB.DataSource = Enum.GetValues(typeof(GameImageType));
            ImagesCB.SelectedIndex = 0;

            RefereshInstallationStatus();

            //LaunchboxOps.AddNewGame("Test", "C:\\temp\\project tests\\C64DreamsImporter\\TestLauncboxInstall\\LaunchBox\\C64 Dreams\\Games\\3-D Skramble\\3-D Skramble.vbs");
        }

        private void DisablePages()
        {
            foreach (TabPage tabPage in MainTC.TabPages)
            {
                tabPage.SuspendLayout();
            }
        }
        private void EnablePages()
        {
            foreach (TabPage tabPage in MainTC.TabPages)
            {
                tabPage.ResumeLayout();
            }
        }

        private void NavBarBT_Click(object sender, EventArgs e)
        {
            DisablePages();
            navBarTicker.Start();
        }

        private void navBarTicker_Tick(object sender, EventArgs e)
        {
            NavBarPN.Width += navBarTransitionPixelChange;
            if (NavBarPN.Width <= navBarMinWidth)
            {
                navBarTransitionPixelChange = -navBarTransitionPixelChange;
                navBarTicker.Stop();
                EnablePages();
            }
            else if (NavBarPN.Width >= navBarMaxWidth)
            {
                navBarTransitionPixelChange = -navBarTransitionPixelChange;
                navBarTicker.Stop();
                EnablePages();
            }
        }
        private void NavGamesBT_Click(object sender, EventArgs e)
        {
            ReviewUILocks();
            MainTC.SelectedTab = GamesTP;
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
        private bool OperationCanBeRun()
        {
            if (operationRunning)
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox("An operation is already running. Please wait for it to finish.", "Operation in progress",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, "Operation in progress", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
                return false;
            }
            return true;
        }

        private void OperationOutcomePrompt(Exception e, string successShort, string successLong, string failiurShort, string failiurLong)
        {
            if (e == null)
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    successLong, successShort, MessageBoxButtons.OK, MessageBoxIcon.Information,
                    "C64 Dreams Import Outcome", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.VerySmall);


                messageBox.ShowDialog(this);
            }
            else
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                   $"{failiurLong}/n/n{e.Message}", failiurShort, MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    "C64 Dreams Import Outcome", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Medium);

                Log($"C64Dreams Import unsuccessful. Details:\n{e.Message}");

                messageBox.ShowDialog(this);
            }
        }

        private void Progress_ProgressChanged(object? sender, OperationProgressChangedEventArgs e)
        {
            if (StatusPB.Style == ProgressBarStyle.Marquee) StatusPB.Style = ProgressBarStyle.Continuous;
            if (e.CurrentSecondaryOperation != null) StatusPrimaryOpLB.Text = e.CurrentSecondaryOperation;
            StatusSecondaryOpLB.Text = e.CurrentMainOperation;
            StatusPB.Value = e.MainPercentageComplete;
        }

        private void ReviewUILocks()
        {
            // C64Dreams Install tab
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

            // Game Add Tab
            if (Properties.Settings.Default.ValidLbPath && Directory.Exists(Path.Combine(Settings.Default.LaunchboxRootPath, "C64 Dreams")))
            {
                AddGamePN.Enabled = true;
                AddGameWarningLB.Visible = false;
            }
            else
            {
                AddGamePN.Enabled = false;
                AddGameWarningLB.Visible = true;
            }
        }

        private void SettsOPenConfigBT_Click(object sender, EventArgs e)
        {
            string candidatePath = Path.Combine(Settings.Default.LaunchboxRootPath, @"C64 Dreams\Utilities\ASuite\ASuite.exe");
            if (File.Exists(candidatePath))
            {
                Process.Start(candidatePath);
            }
            else
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    $"Could not find the file Configurator.exe. Have you installed C64Dreams correctly?",
                    "Configurator.exe not found", MessageBoxButtons.OK, MessageBoxIcon.Warning, "File Missing", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
            }
        }

        private void SettsOpenUtilsBT_Click(object sender, EventArgs e)
        {
            string candidatePath = Path.Combine(Settings.Default.LaunchboxRootPath, @"C64 Dreams\Utilities");
            if (Directory.Exists(candidatePath))
            {
                //Directory.SetCurrentDirectory(candidatePath);
                Process.Start("explorer.exe", candidatePath);
            }
            else
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    $"Could not find the Utilities folder. Have you installed C64Dreams correctly? It should exist at this path: \n\n {candidatePath}",
                    "Utilities folder not found", MessageBoxButtons.OK, MessageBoxIcon.Warning, "Folder Missing", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
            }
        }

        private void SettsRetroarchBT_Click(object sender, EventArgs e)
        {
            string candidatePath = Path.Combine(Settings.Default.LaunchboxRootPath, @"C64 Dreams\Retroarch\Retroarch.exe");
            if (File.Exists(candidatePath))
            {
                Process.Start(candidatePath);
            }
            else
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    $"Could not find the file Retroarch.exe. Have you installed C64Dreams correctly? SHould be at filepath:\n\n {candidatePath}",
                    "Retroarch.exe not found", MessageBoxButtons.OK, MessageBoxIcon.Warning, "File Missing", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
            }

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
                messageBox.ShowDialog(this);


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
                ReviewUILocks();
            }
            return true;
        }

        private bool TestLbPath(string oldpath = null)
        {
            if (Services.FileObjectTests.IsLaunchboxRoot(LaunchboxFBD.Path) == false)
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox("The path selected for launchbox does not contain Launchbox.exe or the" +
                " Directory 'Core' meaning this is likely an incorrect path. Please review", "Launchbox Root Path incorrect.",
                MessageBoxButtons.OK, MessageBoxIcon.Error, "Invalid Directory", DarkMode,
                stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);

                if (oldpath != null) LaunchboxFBD.Path = oldpath;
                return false;
            }
            else
            {
                Properties.Settings.Default.LaunchboxRootPath = LaunchboxFBD.Path;
                Properties.Settings.Default.ValidLbPath = true;
                Properties.Settings.Default.Save();
                ReviewUILocks();
            }
            return true;
        }



        private void AddGame()
        {


            if (AlsoUpdateLbChB.Checked && LaunchboxOps.LaunchboxExecutablesRunning())
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                        "You cannot update the Launchbox database whilst either Launchbox or Bigbox are running. Please close these apps and try again. Game not added", "Lanchbox executables running",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, "Add Game Error", DarkMode,
                        stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);

                messageBox.ShowDialog(this);
                return;
            }

            StatusPB.Style = ProgressBarStyle.Marquee;
            StatusPrimaryOpLB.Text = "Adding Game to Launchbox...";
            StatusSecondaryOpLB.Text = "";
            NavBarPN.Enabled = false;
            AddGameBT.Enabled = false;

            Game gameDetails = new Game()
            {
                CustomCmdText = CustomCmdTB.Text,
                GameFile = GameFIleFB.Path,
                MagazinePageNumber = (int)PageNumberNUM.Value,
                ManualPath = ManualFB.Path,
                SidPath = SidFB.Path,
                MagazinePath = MagazineFB.Path,
                Name = GameNameTB.Text,
                Developer = DeveloperTB.Text,
                Publisher = PublisherTB.Text,
                Notes = NotesTB.Text,
                AlsoUpdateLaunchbox = AlsoUpdateLbChB.Checked,
                WarnOnOverwrite = WarnOnOverwriteChB.Checked,
                GameImages = addGame.GameImages,
                DarkMode = DarkMode,
                MainForm = this
            };

            string result = GameOps.AddGame(gameDetails, DarkMode, this);

            if (result != null)
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    result, "Could not add game",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, "Add Game Error", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.Size = new Size(800, 275);
                messageBox.ShowDialog(this);
            }
            else
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    "Rejoice. Said game hast been added to Launchbox!", "Game added successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, "Game Added", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.Small);
                messageBox.ShowDialog(this);
            }

            StatusPB.Style = ProgressBarStyle.Continuous;
            StatusPrimaryOpLB.Text = "No operation running.";
            StatusSecondaryOpLB.Text = "";
            NavBarPN.Enabled = true;
            AddGameBT.Enabled = true;

        }

        private void ClearAddGame()
        {
            // Clear the form
            GameNameTB.Text = string.Empty;
            GameFIleFB.Path = string.Empty;
            SidFB.Path = string.Empty;
            ManualFB.Path = string.Empty;
            CustomCmdTB.Text = string.Empty;
            MagazineFB.Path = string.Empty;
            PageNumberNUM.Value = 0;
            DeveloperTB.Text = string.Empty;
            PublisherTB.Text = string.Empty;
            NotesTB.Text = string.Empty;
            // Clear images
            addGame.GameImages.Clear();
            ImagesCB.SelectedIndex = 0;
            ImagePathFB.Path = string.Empty;
            GameImagePB.Image = null;
        }

        private void ImagePathFB_PathChanged(stigzler.Winforms.Base.Events.FileSystemObjectChangedEventArgs e)
        {
            // First check is an image:
            if (!Settings.Default.AllowedImageExtensions.Contains(Path.GetExtension(ImagePathFB.Path)))
            {
                stigzler.Winforms.Base.Forms.MessageBox messageBox = new stigzler.Winforms.Base.Forms.MessageBox(
                    "The selected file is not a permitted image file", "Invalid Image file",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, "Invalid Image", DarkMode,
                    stigzler.Winforms.Base.Forms.MessageBox.MessageBoxSize.VerySmall);
                return;
            }

            if (addGame.GameImages.ContainsKey((GameImageType)ImagesCB.SelectedValue))
            {
                addGame.GameImages[(GameImageType)ImagesCB.SelectedValue] = ImagePathFB.Path;
            }
            else
            {
                addGame.GameImages.Add((GameImageType)ImagesCB.SelectedValue, ImagePathFB.Path);
            }

            ChangeGameImage(addGame.GameImages[(GameImageType)ImagesCB.SelectedValue]);

        }

        private void RefereshInstallationStatus()
        {
            if (Settings.Default.C64DInstalled)
            {
                C64DInstalledIL.Image = Resources.greenCheck;
                C64DInstalledIL.Text = "Installed";
            }

            if (Settings.Default.HotfixInstalled)
            {
                HotfixInstalledIL.Image = Resources.greenCheck;
                HotfixInstalledIL.Text = "Installed";
            }

            if (Settings.Default.MagsInstalled)
            {
                MagPackInstallIL.Image = Resources.greenCheck;
                MagPackInstallIL.Text = "Installed";
            }
        }

        private void ImagesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addGame.GameImages.ContainsKey((GameImageType)ImagesCB.SelectedValue))
            {
                ImagePathFB.Path = addGame.GameImages[(GameImageType)ImagesCB.SelectedValue];
                ChangeGameImage(addGame.GameImages[(GameImageType)ImagesCB.SelectedValue]);
            }
            else
            {
                ImagePathFB.Path = string.Empty;
                GameImagePB.Image = null;
            }
        }

        private void ChangeGameImage(string path)
        {
            GameImagePB.Image = Image.FromFile(path);
        }

        private void RemoveIMageBT_Click(object sender, EventArgs e)
        {
            RemoveGameImage();
        }

        private void RemoveGameImage()
        {
            if (addGame.GameImages.ContainsKey((GameImageType)ImagesCB.SelectedValue))
            {
                addGame.GameImages.Remove((GameImageType)ImagesCB.SelectedValue);
                ImagePathFB.Path = string.Empty;
                GameImagePB.Image = null;
            }
        }

        private void GameslistNameTB_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.GameslistName = GameslistNameTB.Text;
        }

        private void AddGameBT_Click(object sender, EventArgs e)
        {
            AddGame();
        }

        private void ClearFormBT_Click(object sender, EventArgs e)
        {
            ClearAddGame();
        }
    }
}
