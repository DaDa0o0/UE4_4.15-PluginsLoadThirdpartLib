// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class FilePathLoad : ModuleRules
{

    private string ModulePath
    {
        get { return ModuleDirectory; }
    }
    private string ThirdPartPath
    {
        get { return Path.Combine(ModulePath, "../../MyLibrary"); }
    }

    public FilePathLoad(TargetInfo Target)
	{
        





        PublicIncludePaths.AddRange(
            new string[] {
                "FilePathLoad/Public"
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"FilePathLoad/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        PublicAdditionalLibraries.Add(Path.Combine(ThirdPartPath, "Libs", "Mine.lib"));
        PublicIncludePaths.Add(Path.Combine(ThirdPartPath, "Include"));


    }
}
