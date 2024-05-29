using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enviroment")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}