using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void Update()
    {
        if (CollectableScript.end == 2)
        {
            SceneManager.LoadScene(2);
            CollectableScript.end = 0;
        }
    }
}
