// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FlickerTarget : TargetRules
{
	public FlickerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		//for Steam online subsystem stetup
		bUsesSteam = true;

		ExtraModuleNames.AddRange( new string[] { "Flicker" } );
	}
}
