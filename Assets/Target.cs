using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Renderer rnd;
    // Start is called before the first frame update
    void Start()
    {
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onMouseEnter()
    {
        rnd.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rnd.material.color = Color.white;
    }
}
