using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndItems : MonoBehaviour
{
    public GameObject particleEffect;

    private void OnTriggerEnter(Collider other)
    {
        CollectableScript.end++;
        if (other.name == "Player") {
            Instantiate(particleEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
