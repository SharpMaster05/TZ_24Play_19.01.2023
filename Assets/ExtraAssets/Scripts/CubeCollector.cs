using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    [SerializeField] private Transform _parent;
    [SerializeField] private GameObject _cubeForCreate;
    [SerializeField] private GameObject _man;

    private Animator _animator;

    private void Start()
    {
        _animator = _man.GetComponent<Animator>();
    }

    private Vector3 _createPosition;
    private Vector3 _newManPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CubePickUp")
        {
            _animator.SetTrigger("Jump");
            
            _createPosition = new Vector3(_man.transform.position.x, 
                                          _man.transform.position.y, 
                                          _man.transform.position.z);

            _newManPosition = new Vector3(_man.transform.position.x, _man.transform.position.y + 1, _man.transform.position.z);
            _man.transform.position = _newManPosition;
            
            Instantiate(_cubeForCreate, _createPosition, Quaternion.identity, _parent);
            Destroy(other.gameObject);
         
            _animator.SetTrigger("Idle");
        }
    }
}
