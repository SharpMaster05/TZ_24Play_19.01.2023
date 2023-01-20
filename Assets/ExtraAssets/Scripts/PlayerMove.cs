using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText; 
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;
    [SerializeField] private int _score;


    private float _directionX;

    private void Update()
    {
        AutoRun();
        PlayerControl();
        _score = (int)transform.position.z;
        _scoreText.text = $"Score:{_score}";
    }

    private void PlayerControl()
    {
        _directionX = _joystick.Horizontal * 2;
        transform.position = new Vector3(_directionX, transform.position.y, transform.position.z);
    }

    private void AutoRun()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }

}
