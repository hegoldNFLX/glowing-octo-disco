using UnrealBuildTool;

public class DemoPluginTests : TestModuleRules
{
	public DemoPluginTests(ReadOnlyTargetRules Target) : base(Target)
	{
		//PrivateIncludePaths.AddRange(
			// Any private include paths from test target module MyModule
		//);

		PrivateDependencyModuleNames.AddRange(
			new[] { "DemoPlugin" }
		);
		
		// Other types of dependencies minimally required to test a specific module

		UpdateBuildGraphPropertiesFile(new Metadata("DemoPlugin", "Demo Plugin"));
	}
}