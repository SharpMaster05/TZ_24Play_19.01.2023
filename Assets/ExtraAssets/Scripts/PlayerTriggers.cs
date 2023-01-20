using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTriggers : MonoBehaviour
{
    [SerializeField] private TrackGroundSpowner _spowner;
    [SerializeField] private Image _restartPanel;
    
    private PlayerMove _playerMove;

    private void Start()
    {
        _playerMove = GetComponentInParent<PlayerMove>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Generator")
        {
            _spowner.NewPositionZ += 30;
            _spowner.GraundTrackSpown();
        }
        if(other.tag == "Wall")
        {
            _playerMove.enabled = false;
            _restartPanel.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            _playerMove.enabled = false;
            _restartPanel.gameObject.SetActive(true);
        }
    }
}
