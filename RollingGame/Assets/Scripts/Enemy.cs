using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody _rb;
    private GameObject player;
    private Vector3 _lookDirection;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _lookDirection = (player.transform.position - transform.position).normalized;
        _rb.AddForce(_lookDirection * speed);
    }
}
