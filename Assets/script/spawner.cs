
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float time;
    [SerializeField] private float _yClamp;

    private float _elapsedTime;
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime > time)
        {
            SpawnObject();
            _elapsedTime = 0f;
        }      
    }

    private void SpawnObject()
    {
        float offsetY = Random.Range(-_yClamp,_yClamp);
        Vector2 pos = new Vector2(this.transform.position.x,this.transform.position.y + offsetY);
        Instantiate(_prefab,pos,Quaternion.identity,this.transform);
    }
}
