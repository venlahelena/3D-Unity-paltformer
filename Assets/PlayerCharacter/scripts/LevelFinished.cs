using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinished : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            CompleteLevel();
        }
    }

    private void CompleteLevel()
    {

    }
}
