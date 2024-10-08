using UnityEditor;

class AndroidBuilder
{
    static void PerformBuild()
    {
        // Set scripting backend to IL2CPP
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);

        // Set target architecture to ARM64
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.target = BuildTarget.Android; // More details on BuildTarget doc
        buildPlayerOptions.options = BuildOptions.Development;
        buildPlayerOptions.locationPathName = "AndroidBuild";

        // Perform the build
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}