using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.right * Time.deltaTime);
        this.transform.LookAt(new Vector3());
    }
}
