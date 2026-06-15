// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Assignment10EditorTarget : TargetRules
{
	public Assignment10EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		// 빌드 대상에 Test 모듈 포함 (에디터 타깃)
		ExtraModuleNames.AddRange(new string[] { "Assignment10", "Test" });
	}
}
