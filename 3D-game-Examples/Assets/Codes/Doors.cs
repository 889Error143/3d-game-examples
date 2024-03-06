using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Vector3 _pivotePoint;
    bool _isDoorOpen;
    bool _canDoorsOpen;

    // Start is called before the first frame update
   void Start()
    {
        //_pivotePoint = transform.Position
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && !_isDoorOpen && _canDoorsOpen)
        {
            transform.RotateAround(_pivotPoint, Vector3.up, -90);
            _isDoorOpen = true;
        }

    }
    public void DoorCanBeOpend()
    {
        _canDoorOpen = true;
    }
}