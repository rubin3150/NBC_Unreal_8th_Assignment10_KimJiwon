// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Assignment10Target : TargetRules
{
	public Assignment10Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		// 빌드 대상에 Test 모듈 포함 (게임 타깃)
		ExtraModuleNames.AddRange(new string[] { "Assignment10", "Test" });
	}
}
