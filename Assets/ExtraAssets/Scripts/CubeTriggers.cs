using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            gameObject.transform.SetParent(null);
        }
    }
}
