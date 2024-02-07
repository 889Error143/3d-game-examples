using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpmovement : MonoBehaviour
{
    public float JumpForce = 10f;
    public float GravityModifier = 1f;
    public bool IsOnGround = true;
    public float Speed = 10f;
    public float OutOfBounds = -10f;

    private float _horizontalInput;
    private float _forwardInput;
    private Rigidbody _playerRigidbody;
    private Vector3 _startingPosition;
    private Vector3 _checkpointPosition;
    private bool _isAtCheckpoint = false;

    // Start is called before the first frame update
    void Start()
    {

        _playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
        _startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround)
        {
            _playerRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;

        }
        if (transform.position.y < OutOfBounds)
        {
            if (_isAtCheckpoint)
            {
                transform.position = _checkpointPosition;
            }
            else
            {
                transform.position = _startingPosition;
            }
        }
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_horizontalInput, 0.0f, _forwardInput);

        _playerRigidbody.AddForce(movement * Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
        }
        if (collision.Gameobject./ Compare)
        {
             
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            _isAtCheckpoint = true;
            _startingPosition = other.gameObject.transform.position;
        }
        if(other.gameObject.CompareTag("Endpoint"))
        {
            transform.position = _startingPosition;

        }

    }

}