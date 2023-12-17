// Copyright 2018-2023 YeHaike. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UETCPDemoEditorTarget : TargetRules
{
	public UETCPDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.AddRange( new string[] { "UETCPDemo" } );
	}
}
