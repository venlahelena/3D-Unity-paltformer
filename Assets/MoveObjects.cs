using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MoveObjects : MonoBehaviour
{
    public GameObject[] prefabs = null;
    public Camera cam = null;


    public List<GameObject> targets = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {
        InstanntiateObject();

    }

    public void InstanntiateObject()
    {
        

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray,out hit))
                {
                    if(hit.collider.gameObject.tag == "Block")
                    {
                        targets.Add(hit.collider.gameObject);

                        foreach (var target in targets)
                        {

                            Vector3 moveDirection = new Vector3(0.5f, 0.0f, 0.0f);

                            target.transform.position += moveDirection;

                            print("Moving!");

                        }

                        targets.Clear();

                    }
                }
            }
        }
    }
}
