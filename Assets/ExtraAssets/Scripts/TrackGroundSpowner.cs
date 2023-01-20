using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGroundSpowner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _grounds;
    private float _newPositionZ;

    public void GraundTrackSpown()
    {
        int randomTrackGround = Random.Range(0, _grounds.Count);

        Instantiate(_grounds[randomTrackGround], new Vector3(0, 0, _newPositionZ), Quaternion.identity);
    }

    public float NewPositionZ
    {
        get => _newPositionZ;
        set => _newPositionZ = value;
    }

}
