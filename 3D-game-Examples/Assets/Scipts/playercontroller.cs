using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playercontroller : MonoBehaviour
{


    private float _verticalInput;
    public float Speed = 5f;
    public float RotationSpeed = 45f;

    private float _horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Speed * _verticalInput * Time.deltaTime);

        // turn the vehicle

        transform.Rotate(Vector3.up, RotationSpeed * _horizontalInput * Time.deltaTime);

    }





}
