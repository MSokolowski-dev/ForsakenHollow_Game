using UnrealBuildTool;

public class HorrorGameClientTarget : TargetRules
{
	public HorrorGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HorrorGame");
	}
}
