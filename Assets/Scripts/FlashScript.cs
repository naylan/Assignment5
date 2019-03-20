using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour
{
    public bool flashOn;
    // Start is called before the first frame update
    void Start()
    {
        flashOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashOn == false) 
            {
                this.GetComponent<Light>().enabled = true;
                flashOn = true;
            }
            else {
                this.GetComponent<Light>().enabled = false;
                flashOn = false;
            }
        }
    }
}
