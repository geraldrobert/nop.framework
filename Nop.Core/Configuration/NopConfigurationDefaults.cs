namespace Nop.Core.Configuration
{
    /// <summary>
    /// Represents default values related to configuration services
    /// </summary>
    public static partial class NopConfigurationDefaults
    {
        /// <summary>
        /// Gets the path to file that contains app settings
        /// </summary>
        public static string AppSettingsFilePath => "appsettings.json";

        /// <summary>
        /// Get or set Cache key prefix
        /// </summary>
        public static string CacheKeyPrefix = "nop";
    }
}