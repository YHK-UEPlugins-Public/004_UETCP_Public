// Copyright 2018-2023 YeHaike. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UETCPDemoTarget : TargetRules
{
	public UETCPDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UETCPDemo" } );
	}
}
