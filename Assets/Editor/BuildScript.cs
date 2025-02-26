using UnityEditor;

public static class BuildScript
{
    public static void PerformBuild()
    {
        string buildPath = "build/StandaloneWindows64/MyGame.exe";
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}
