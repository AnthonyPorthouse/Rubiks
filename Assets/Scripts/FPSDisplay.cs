using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
    private double DeltaTime { get; set; }
    
    // Update is called once per frame
    void Update()
    {
        DeltaTime += (Time.unscaledDeltaTime - DeltaTime) * .1;
    }

    private void OnGUI()
    {
        var style = new GUIStyle();
        var rect = new Rect(0, 0, Screen.width, Screen.height * 0.02f);
        style.alignment = TextAnchor.UpperRight;
        style.fontSize = Screen.height * 2 / 100;
        style.normal.textColor = Color.Lerp(Color.green, Color.black, .5f);
        var fps = 1f / DeltaTime;

        var text = $"{fps:0.} fps";
        GUI.Label(rect, text, style);
    }
}
