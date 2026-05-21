
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    private List<Vector3> _points = new List<Vector3>();

    private void Awake()
    {
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        for (int i = 0; i < mesh.vertexCount; i++)
        {
            if(_points.Count < 3)
                _points.Add(mesh.vertices[i]);
        }
    }

    private void Update()
    {
        DrawLine();

        if (Input.GetMouseButton(0))
        {
            
        }
            

    }

    private void DrawLine()
    {
        Debug.DrawLine(transform.position, transform.forward * 2, Color.blue);

        Vector3 cameraPoint = Camera.main.transform.position + Camera.main.transform.forward * 5;

        Vector3 edge1 = _points[1] - _points[0];
        Vector3 edge2 = cameraPoint - _points[1];
        Vector3 edge3 = _points[2] - _points[1];
        Vector3 edge4 = cameraPoint - _points[2];
        Vector3 edge5 = _points[0] - _points[2];
        Vector3 edge6 = cameraPoint - _points[0];

        Vector3 cp1 = Vector3.Cross(edge1, edge2);
        Vector3 cp2 = Vector3.Cross(edge3, edge4);
        Vector3 cp3 = Vector3.Cross(edge5, edge6);

        if(Vector3.Dot(cp1, cp2) > 0 && Vector3.Dot(cp2, cp3) > 0)
        {
            Debug.DrawLine(Camera.main.transform.position, cameraPoint, Color.red);
        }
        else
        {
            Debug.DrawLine(Camera.main.transform.position, cameraPoint, Color.blue);
        }
    }
}
