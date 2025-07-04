using UnrealBuildTool;

public class HorrorGameServerTarget : TargetRules
{
	public HorrorGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HorrorGame");
	}
}
