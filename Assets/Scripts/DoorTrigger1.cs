using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger1 : MonoBehaviour
{
    private Animator _animator;

    public GameObject door;
    bool isOpen = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectableScript.points == 6 && !isOpen) {
            isOpen = true;
            _animator.SetBool("isopen", true);
        }
    }
}
