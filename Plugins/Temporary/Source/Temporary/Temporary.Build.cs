using UnrealBuildTool;

// Temporary 플러그인의 런타임 모듈 빌드 규칙
public class Temporary : ModuleRules
{
    public Temporary(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine" });

        PrivateDependencyModuleNames.AddRange(new string[] { });
    }
}