using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.BuildOptions;
using static UnityEditor.BuildPipeline;
using static UnityEditor.BuildTarget;

public class BuildScript : MonoBehaviour
{
    public static void BuildAll()
    {
        
        
        Debug.Log(BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Mac/Rubiks.app",
            StandaloneOSX,
            None
        ));
        
        Debug.Log(BuildPlayer(
            new[] {"Assets/Scenes/SampleScene.unity"},
            "Build/Windows/Rubiks.exe",
            StandaloneWindows64,
            None
        ));
    }
}
