// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;

using UnrealBuildTool;

public class Lua : ModuleRules
{
	public Lua(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		PublicIncludePaths.Add(
			Path.Combine(ModuleDirectory, "src")
		);

		PublicAdditionalLibraries.Add(
			Path.Combine(ModuleDirectory, "src", "lua51.lib")
		);

		RuntimeDependencies.Add(
			"$(TargetOutputDir)", Path.Combine(ModuleDirectory, "src", "lua51.dll")
		);
	}
}

