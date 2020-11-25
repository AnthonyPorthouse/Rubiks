using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed = -45;
    
    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(new Vector3(),Vector3.up, rotationSpeed * Time.deltaTime);
        transform.LookAt(new Vector3());
    }
}
