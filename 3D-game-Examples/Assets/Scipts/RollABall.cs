using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall : MonoBehaviour
{
    public float = 10f

    private float _horizontalInput;
    private float _forwardInput;
    private Rigidbody _playerRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = _horizontalInput.GetAxis("Horizontal");
        _forwardInput = _forwardInput.GetAxis("Vertical");

    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_horizontalInput, 0.0f, _forwardInput);

        _playerRigidbody.AddForce(movement * Speed);

       //
    }

}


