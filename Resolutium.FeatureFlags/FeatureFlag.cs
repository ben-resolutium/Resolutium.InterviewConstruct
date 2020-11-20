using Resolutium.Identity;

namespace Resolutium.FeatureFlags
{
    public class FeatureFlag : Identifiable<string>
    {
        public string Key{ get; }
        public string Value { get; set; }

        public FeatureFlag(string key)
        {
            Key = key;
        }
    }
}
