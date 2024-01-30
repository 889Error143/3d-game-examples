using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollEnemy : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody _EnemyRB;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _EnemyRB = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (_player.transform.position - transform.position).normalized;
        _EnemyRB.AddForce(lookDirection * speed);
    }
}
