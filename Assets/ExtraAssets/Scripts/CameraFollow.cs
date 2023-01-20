using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _cameraPosition;
    public void LateUpdate()
    {
        transform.position = _cameraPosition.position;
       
    }
}
