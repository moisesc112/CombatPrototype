// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CombatPrototype : ModuleRules
{
	public CombatPrototype(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CombatPrototype",
			"CombatPrototype/Variant_Platforming",
			"CombatPrototype/Variant_Platforming/Animation",
			"CombatPrototype/Variant_Combat",
			"CombatPrototype/Variant_Combat/AI",
			"CombatPrototype/Variant_Combat/Animation",
			"CombatPrototype/Variant_Combat/Gameplay",
			"CombatPrototype/Variant_Combat/Interfaces",
			"CombatPrototype/Variant_Combat/UI",
			"CombatPrototype/Variant_SideScrolling",
			"CombatPrototype/Variant_SideScrolling/AI",
			"CombatPrototype/Variant_SideScrolling/Gameplay",
			"CombatPrototype/Variant_SideScrolling/Interfaces",
			"CombatPrototype/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
