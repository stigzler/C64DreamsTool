using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C64DreamsTool.Data.Entities
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Game));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Game)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Game")]
    public class LaunchboxGame
    {

        [XmlElement(ElementName = "GogAppId")]
        public object GogAppId { get; set; }

        [XmlElement(ElementName = "OriginAppId")]
        public object OriginAppId { get; set; }

        [XmlElement(ElementName = "OriginInstallPath")]
        public object OriginInstallPath { get; set; }

        [XmlElement(ElementName = "VideoPath")]
        public object VideoPath { get; set; }

        [XmlElement(ElementName = "ThemeVideoPath")]
        public object ThemeVideoPath { get; set; }

        [XmlElement(ElementName = "Installed")]
        public bool Installed { get; set; }

        [XmlElement(ElementName = "ApplicationPath")]
        public string ApplicationPath { get; set; }

        [XmlElement(ElementName = "CommandLine")]
        public object CommandLine { get; set; }

        [XmlElement(ElementName = "Completed")]
        public bool Completed { get; set; }

        [XmlElement(ElementName = "ConfigurationCommandLine")]
        public object ConfigurationCommandLine { get; set; }

        [XmlElement(ElementName = "ConfigurationPath")]
        public object ConfigurationPath { get; set; }

        [XmlElement(ElementName = "DateAdded")]
        public DateTime DateAdded { get; set; }

        [XmlElement(ElementName = "DateModified")]
        public DateTime DateModified { get; set; }

        [XmlElement(ElementName = "Developer")]
        public string Developer { get; set; }

        [XmlElement(ElementName = "DosBoxConfigurationPath")]
        public object DosBoxConfigurationPath { get; set; }

        [XmlElement(ElementName = "Emulator")]
        public object Emulator { get; set; }

        [XmlElement(ElementName = "Favorite")]
        public bool Favorite { get; set; }

        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }

        [XmlElement(ElementName = "ManualPath")]
        public object ManualPath { get; set; }

        [XmlElement(ElementName = "MusicPath")]
        public object MusicPath { get; set; }

        [XmlElement(ElementName = "Notes")]
        public string Notes { get; set; }

        [XmlElement(ElementName = "Platform")]
        public string Platform { get; set; }

        [XmlElement(ElementName = "Publisher")]
        public string Publisher { get; set; }

        [XmlElement(ElementName = "Rating")]
        public object Rating { get; set; }

        [XmlElement(ElementName = "ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [XmlElement(ElementName = "RootFolder")]
        public string RootFolder { get; set; }

        [XmlElement(ElementName = "ScummVMAspectCorrection")]
        public bool ScummVMAspectCorrection { get; set; }

        [XmlElement(ElementName = "ScummVMFullscreen")]
        public bool ScummVMFullscreen { get; set; }

        [XmlElement(ElementName = "ScummVMGameDataFolderPath")]
        public object ScummVMGameDataFolderPath { get; set; }

        [XmlElement(ElementName = "ScummVMGameType")]
        public object ScummVMGameType { get; set; }

        [XmlElement(ElementName = "SortTitle")]
        public object SortTitle { get; set; }

        [XmlElement(ElementName = "Source")]
        public object Source { get; set; }

        [XmlElement(ElementName = "StarRatingFloat")]
        public int StarRatingFloat { get; set; }

        [XmlElement(ElementName = "StarRating")]
        public int StarRating { get; set; }

        [XmlElement(ElementName = "CommunityStarRating")]
        public int CommunityStarRating { get; set; }

        [XmlElement(ElementName = "CommunityStarRatingTotalVotes")]
        public int CommunityStarRatingTotalVotes { get; set; }

        [XmlElement(ElementName = "Status")]
        public object Status { get; set; }

        [XmlElement(ElementName = "DatabaseID")]
        public int DatabaseID { get; set; }

        [XmlElement(ElementName = "WikipediaURL")]
        public string WikipediaURL { get; set; }

        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "UseDosBox")]
        public bool UseDosBox { get; set; }

        [XmlElement(ElementName = "UseScummVM")]
        public bool UseScummVM { get; set; }

        [XmlElement(ElementName = "Version")]
        public object Version { get; set; }

        [XmlElement(ElementName = "Series")]
        public object Series { get; set; }

        [XmlElement(ElementName = "PlayMode")]
        public string PlayMode { get; set; }

        [XmlElement(ElementName = "Region")]
        public object Region { get; set; }

        [XmlElement(ElementName = "PlayCount")]
        public int PlayCount { get; set; }

        [XmlElement(ElementName = "PlayTime")]
        public int PlayTime { get; set; }

        [XmlElement(ElementName = "Portable")]
        public bool Portable { get; set; }

        [XmlElement(ElementName = "Hide")]
        public bool Hide { get; set; }

        [XmlElement(ElementName = "Broken")]
        public bool Broken { get; set; }

        [XmlElement(ElementName = "CloneOf")]
        public object CloneOf { get; set; }

        [XmlElement(ElementName = "Genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "MissingVideo")]
        public bool MissingVideo { get; set; }

        [XmlElement(ElementName = "MissingBoxFrontImage")]
        public bool MissingBoxFrontImage { get; set; }

        [XmlElement(ElementName = "MissingScreenshotImage")]
        public bool MissingScreenshotImage { get; set; }

        [XmlElement(ElementName = "MissingMarqueeImage")]
        public bool MissingMarqueeImage { get; set; }

        [XmlElement(ElementName = "MissingClearLogoImage")]
        public bool MissingClearLogoImage { get; set; }

        [XmlElement(ElementName = "MissingBackgroundImage")]
        public bool MissingBackgroundImage { get; set; }

        [XmlElement(ElementName = "MissingBox3dImage")]
        public bool MissingBox3dImage { get; set; }

        [XmlElement(ElementName = "MissingCartImage")]
        public bool MissingCartImage { get; set; }

        [XmlElement(ElementName = "MissingCart3dImage")]
        public bool MissingCart3dImage { get; set; }

        [XmlElement(ElementName = "MissingManual")]
        public bool MissingManual { get; set; }

        [XmlElement(ElementName = "MissingBannerImage")]
        public bool MissingBannerImage { get; set; }

        [XmlElement(ElementName = "MissingMusic")]
        public bool MissingMusic { get; set; }

        [XmlElement(ElementName = "UseStartupScreen")]
        public bool UseStartupScreen { get; set; }

        [XmlElement(ElementName = "HideAllNonExclusiveFullscreenWindows")]
        public bool HideAllNonExclusiveFullscreenWindows { get; set; }

        [XmlElement(ElementName = "StartupLoadDelay")]
        public int StartupLoadDelay { get; set; }

        [XmlElement(ElementName = "HideMouseCursorInGame")]
        public bool HideMouseCursorInGame { get; set; }

        [XmlElement(ElementName = "DisableShutdownScreen")]
        public bool DisableShutdownScreen { get; set; }

        [XmlElement(ElementName = "AggressiveWindowHiding")]
        public bool AggressiveWindowHiding { get; set; }

        [XmlElement(ElementName = "OverrideDefaultStartupScreenSettings")]
        public bool OverrideDefaultStartupScreenSettings { get; set; }

        [XmlElement(ElementName = "UsePauseScreen")]
        public bool UsePauseScreen { get; set; }

        [XmlElement(ElementName = "PauseAutoHotkeyScript")]
        public object PauseAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "ResumeAutoHotkeyScript")]
        public object ResumeAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "OverrideDefaultPauseScreenSettings")]
        public bool OverrideDefaultPauseScreenSettings { get; set; }

        [XmlElement(ElementName = "SuspendProcessOnPause")]
        public bool SuspendProcessOnPause { get; set; }

        [XmlElement(ElementName = "ForcefulPauseScreenActivation")]
        public bool ForcefulPauseScreenActivation { get; set; }

        [XmlElement(ElementName = "LoadStateAutoHotkeyScript")]
        public object LoadStateAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "SaveStateAutoHotkeyScript")]
        public object SaveStateAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "ResetAutoHotkeyScript")]
        public object ResetAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "SwapDiscsAutoHotkeyScript")]
        public object SwapDiscsAutoHotkeyScript { get; set; }

        [XmlElement(ElementName = "CustomDosBoxVersionPath")]
        public object CustomDosBoxVersionPath { get; set; }

        [XmlElement(ElementName = "ReleaseType")]
        public string ReleaseType { get; set; }

        [XmlElement(ElementName = "MaxPlayers")]
        public int MaxPlayers { get; set; }

        [XmlElement(ElementName = "VideoUrl")]
        public object VideoUrl { get; set; }

        [XmlElement(ElementName = "AndroidBoxFrontThumbPath")]
        public object AndroidBoxFrontThumbPath { get; set; }

        [XmlElement(ElementName = "AndroidBoxFrontFullPath")]
        public object AndroidBoxFrontFullPath { get; set; }

        [XmlElement(ElementName = "AndroidClearLogoThumbPath")]
        public object AndroidClearLogoThumbPath { get; set; }

        [XmlElement(ElementName = "AndroidClearLogoFullPath")]
        public object AndroidClearLogoFullPath { get; set; }

        [XmlElement(ElementName = "AndroidBackgroundPath")]
        public object AndroidBackgroundPath { get; set; }

        [XmlElement(ElementName = "AndroidBackgroundThumbPath")]
        public object AndroidBackgroundThumbPath { get; set; }

        [XmlElement(ElementName = "AndroidGameTitleScreenshotThumbPath")]
        public object AndroidGameTitleScreenshotThumbPath { get; set; }

        [XmlElement(ElementName = "AndroidGameplayScreenshotThumbPath")]
        public object AndroidGameplayScreenshotThumbPath { get; set; }

        [XmlElement(ElementName = "AndroidGameTitleScreenshotPath")]
        public object AndroidGameTitleScreenshotPath { get; set; }

        [XmlElement(ElementName = "AndroidGameplayScreenshotPath")]
        public object AndroidGameplayScreenshotPath { get; set; }

        [XmlElement(ElementName = "AndroidVideoPath")]
        public object AndroidVideoPath { get; set; }

        [XmlElement(ElementName = "HasCloudSynced")]
        public bool HasCloudSynced { get; set; }
    }



}

