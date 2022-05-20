using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Death")
        {
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
}
