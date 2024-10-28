using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMARAYADON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = GameObject.Find("kapsul_statik").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //get camera object's rotatation
        Vector3 cameraRotation = Camera.main.transform.rotation.eulerAngles;
        // assign to object's rotation in all axis
        transform.rotation = Quaternion.Euler(cameraRotation.x, cameraRotation.y, cameraRotation.z);
    }
}
