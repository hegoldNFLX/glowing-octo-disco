using UnrealBuildTool;

[SupportedPlatforms(UnrealPlatformClass.All)]
public class DemoPluginTestsTarget : TestTargetRules
{
	public DemoPluginTestsTarget(TargetInfo Target) : base(Target)
	{
		bCompileAgainstCoreUObject = true;
		bCompileAgainstApplicationCore = true;

		// Optionally add global definitions for Catch2 benchmarking etc.
		GlobalDefinitions.Add("CATCH_CONFIG_ENABLE_BENCHMARKING=1");
    }
}