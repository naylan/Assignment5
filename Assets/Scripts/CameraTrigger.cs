using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject CamOn;
    public GameObject CamOff;

    private void OnTriggerEnter(Collider other)
    {
        CamOn.SetActive(true);
        CamOff.SetActive(false);
    }
}
