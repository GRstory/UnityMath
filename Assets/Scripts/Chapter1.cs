using UnityEngine;
using UnityEngine.EventSystems;

public class Chapter1 : MonoBehaviour
{
    [SerializeField] private GameObject _spherePrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouseScreenPosition = Input.mousePosition;
            mouseScreenPosition.z = 0f;

            Vector3 selfScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
            selfScreenPosition.z = 0f;

            Vector3 direction = mouseScreenPosition - selfScreenPosition;
            float radian = Mathf.Atan2(direction.y, direction.x);

            this.transform.eulerAngles = new Vector3(0f, 0f, radian * Mathf.Rad2Deg);

            Debug.Log($"Mouse Position: {mouseScreenPosition}, Self Position: {selfScreenPosition}, Direction: {direction}, Radian: {radian}");
        }

        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(_spherePrefab, Input.mousePosition, Quaternion.identity);
        }
    }
}
