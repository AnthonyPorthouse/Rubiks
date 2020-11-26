using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Build/Build All")]
    public static void BuildAll()
    {
        Debug.Log(BuildPipeline.BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Mac/Rubiks.app",
            BuildTarget.StandaloneOSX,
            BuildOptions.None
        ));

        Debug.Log(BuildPipeline.BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Windows/Rubiks.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        ));

        Debug.Log(BuildPipeline.BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Linux/Rubiks",
            BuildTarget.StandaloneLinux64,
            BuildOptions.None
        ));
        
        Debug.Log(BuildPipeline.BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Web/Rubiks",
            BuildTarget.WebGL,
            BuildOptions.None
        ));
    }
}
