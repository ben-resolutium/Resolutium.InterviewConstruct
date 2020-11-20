namespace Resolutium.FeatureFlags
{
    public interface IFeatureFlagService
    {
        FeatureFlag Get(string key);
    }
}
