﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisCam : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x,
                                        target.transform.position.y,
                                        transform.position.z);
        transform.LookAt(targetPos);
    }
}
