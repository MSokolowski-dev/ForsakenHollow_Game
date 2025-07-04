using UnrealBuildTool;

public class HorrorGameEditorTarget : TargetRules
{
	public HorrorGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HorrorGame");
	}
}
