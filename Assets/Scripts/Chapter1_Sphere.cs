using UnityEngine;

public class Chapter1_Sphere : MonoBehaviour
{
    private float _speed = 2f;
    private float _frequency = 10f;
    private float _spawntime;

    private void Awake()
    {
        _spawntime = Time.time;
    }

    private void Update()
    {
        float x = transform.position.x + (0 - transform.position.x) * Time.deltaTime * _speed;
        float y = Mathf.Abs(Mathf.Sin((Time.time - _spawntime) * (Mathf.PI * 2) * _frequency))* _speed;


        transform.position = new Vector3(x, y, 0);
    }
}
