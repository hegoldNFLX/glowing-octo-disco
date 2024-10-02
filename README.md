# glowing-octo-disco
Minimal repro for LLTs

Error generating project files ("Targets with a unique build environment cannot be built with an installed engine."):

```
Generating VisualStudio project files:
Discovering modules, targets and source code for project...
Found Visual Studio installation: C:\Program Files\Microsoft Visual Studio\2022\Community (Product=Microsoft.VisualStudio.Product.Community, Version=17.11.35312.102)
Found Visual Studio toolchain: C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Tools\MSVC\14.34.31933 (Family=14.34.31933, FamilyRank=0, Version=14.34.31948, Is64Bit=True, Preview=False, Architecture=x64, Error=False, Redist=C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Redist\MSVC\14.40.33807)
Found Visual Studio toolchain: C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Tools\MSVC\14.41.34120 (Family=14.41.34120, FamilyRank=2, Version=14.41.34120, Is64Bit=True, Preview=False, Architecture=x64, Error=False, Redist=C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Redist\MSVC\14.40.33807)
Detected supported platforms: Win64, IOS, Android, Linux, LinuxArm64
Creating project rules assembly for C:\dev\misc\glowing-octo-disco\repro\repro.uproject...
Skipping C:\Program Files\Epic Games\UE_5.2\Engine\Intermediate\Build\BuildRules\UE5Rules.dll: File is installed
Skipping C:\Program Files\Epic Games\UE_5.2\Engine\Intermediate\Build\BuildRules\UE5ProgramRules.dll: File is installed
 Found 1 Plugins:
  C:\dev\misc\glowing-octo-disco\repro\Plugins\DemoPlugin\DemoPlugin.uplugin
 Found 3 Modules:
  C:\dev\misc\glowing-octo-disco\repro\Source\Programs\DemoPluginTests.build.cs
  C:\dev\misc\glowing-octo-disco\repro\Source\repro\repro.Build.cs
  C:\dev\misc\glowing-octo-disco\repro\Plugins\DemoPlugin\Source\DemoPlugin\DemoPlugin.Build.cs
Compiling C:\dev\misc\glowing-octo-disco\repro\Intermediate\Build\BuildRules\reproModuleRules.dll: Assembly does not exist
Targets with a unique build environment cannot be built with an installed engine.
BuildException: Targets with a unique build environment cannot be built with an installed engine.
   at UnrealBuildTool.RulesAssembly.CreateTargetRulesInstance(String TypeName, TargetInfo TargetInfo, ILogger Logger, Boolean IsTestTarget, Boolean bSkipValidation) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\System\RulesAssembly.cs:line 628
   at UnrealBuildTool.RulesAssembly.CreateTargetRules(String TargetName, UnrealTargetPlatform Platform, UnrealTargetConfiguration Configuration, UnrealArchitectures Architectures, FileReference ProjectFile, CommandLineArguments Arguments, ILogger Logger, Boolean IsTestTarget, Boolean bSkipValidation) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\System\RulesAssembly.cs:line 778
   at UnrealBuildTool.ProjectFileGenerator.AddProjectsForAllTargets(PlatformProjectGeneratorCollection PlatformProjectGenerators, List`1 AllGames, List`1 AllTargetFiles, String[] Arguments, ProjectFile& EngineProject, List`1 GameProjects, Dictionary`2 ProjectFileToUProjectFile, Dictionary`2 ProgramProjects, Dictionary`2 RulesAssemblies, ILogger Logger) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\ProjectFiles\ProjectFileGenerator.cs:line 2450
   at UnrealBuildTool.ProjectFileGenerator.GenerateProjectFiles(PlatformProjectGeneratorCollection PlatformProjectGenerators, String[] Arguments, ILogger Logger) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\ProjectFiles\ProjectFileGenerator.cs:line 916
   at UnrealBuildTool.GenerateProjectFilesMode.Execute(CommandLineArguments Arguments, ILogger Logger) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\Modes\GenerateProjectFilesMode.cs:line 67
   at UnrealBuildTool.UnrealBuildTool.Main(String[] ArgumentsArray) in D:\build\++UE5\Sync\Engine\Saved\CsTools\Engine\Source\Programs\UnrealBuildTool\UnrealBuildTool.cs:line 599
WriteFileIfChanged() wrote 0 changed files of 0 requested writes.
```