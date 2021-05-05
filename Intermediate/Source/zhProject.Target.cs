using UnrealBuildTool;

public class zhProjectTarget : TargetRules
{
	public zhProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("zhProject");
	}
}
