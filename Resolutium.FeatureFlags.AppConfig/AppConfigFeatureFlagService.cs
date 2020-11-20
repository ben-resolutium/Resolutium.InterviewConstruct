using System.Configuration;

namespace Resolutium.FeatureFlags
{
    public class AppConfigFeatureFlagService : IFeatureFlagService
    {
        public FeatureFlag Get(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var value = appSettings[key];
            return new FeatureFlag(key)
            {
                Value = value
            };
        }
    }
}
