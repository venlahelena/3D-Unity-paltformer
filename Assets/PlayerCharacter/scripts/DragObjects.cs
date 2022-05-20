using UnityEngine;

public class DragObjects : MonoBehaviour
{
    public GameObject targetObject;

    Vector3 targetObjectNextPosition;

    float targetObjectHeight;

    RaycastHit hit;
  
    void Start()
    {
        targetObjectNextPosition = targetObject.transform.position;
        targetObjectHeight = targetObject.GetComponent<MeshRenderer>().bounds.size.y;
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));

            Vector3 direction = worldMousePosition - Camera.main.transform.position;

            if(Physics.Raycast(Camera.main.transform.position, direction, out hit, 100f))
            {
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);

                if (hit.collider.gameObject.name == "Plane")
                {
                    targetObjectNextPosition = hit.point + new Vector3(0f, targetObjectHeight / 2, 0f);

                    targetObject.transform.position = targetObjectNextPosition;
                }

            } else
            {
                Debug.DrawLine(Camera.main.transform.position, worldMousePosition, Color.red, 0.5f);
            }
        }
    }
 
}
