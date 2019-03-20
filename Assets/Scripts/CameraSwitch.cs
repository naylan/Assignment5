using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public void EnableCam1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    public void EnableCam2()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
