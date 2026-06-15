using UnrealBuildTool;

// 새로 추가한 Test 모듈의 빌드 규칙. 게임 모듈(Assignment10)과 별개로 분리된 모듈
public class Test : ModuleRules
{
	public Test(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// 액터(ATestActor)를 다루기 위한 최소 의존성
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine" });
	}
}