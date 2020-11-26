using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
    
    public double DeltaTime { get; set; }
    
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
        var ms = DeltaTime * 1000;
        var fps = 1f / DeltaTime;

        var text = string.Format("{0:0.0}ms ({1:0.} fps)", ms, fps);
        GUI.Label(rect, text, style);
    }
}
