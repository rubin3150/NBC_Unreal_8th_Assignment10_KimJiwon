// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Assignment10 : ModuleRules
{
	public Assignment10(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// 직접 만든 Test 모듈을 참조해 ATestActor를 사용하기 위해 추가
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "Test" });
	}
}
