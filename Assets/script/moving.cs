using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _xbound;

    void Update()
    {
        this.transform.position -= Vector3.right * _speed * Time.deltaTime;
        
    }
}