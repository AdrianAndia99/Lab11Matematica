using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _force;
    [SerializeField] private float ybound;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && rb.position.y < ybound)
        {
            Flappy();
        }
    }
    private void Flappy()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector2.up * _force);

    }
}