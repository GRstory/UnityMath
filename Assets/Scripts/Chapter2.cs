using UnityEngine;

public class Chapter2 : MonoBehaviour
{
    [SerializeField] private float _radius = 5f;
    [SerializeField] private float _theta = 0f;
    [SerializeField] private float _phi = 0f;


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _phi -= Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _phi += Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            _theta += Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            _theta -= Time.deltaTime;
        }

        //높이 
        float y = Mathf.Sin(_theta);
        //Mathf.Cos(_theta)를 곱하는 이유는 x, z축의 선분이 radius의 길이보다 짧아지기 때문에
        float x = Mathf.Cos(_theta) * Mathf.Cos(_phi);
        float z = Mathf.Cos(_theta) * Mathf.Sin(_phi);

        transform.position = new Vector3(x, y, z) * _radius;

        transform.LookAt(Vector3.zero);
    }
}
