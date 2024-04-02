using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] KeyCode keyCode;
    [SerializeField] GameObject spawnable;
    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            Instantiate(spawnable, transform.position, transform.rotation);
        }
    }
}
