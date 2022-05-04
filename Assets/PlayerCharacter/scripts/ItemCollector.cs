using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int apples = 0;
    private int mushrooms = 0;

    [SerializeField] private Text applesText;
    [SerializeField] private Text mushroomsText;

    private void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            apples++;
            applesText.text = "Apples: " + apples;
            
        }
        if(collision.gameObject.CompareTag("Mushroom"))
        {
            Destroy(collision.gameObject);
            mushrooms++;
            mushroomsText.text = "Mushrooms: " + mushrooms;
            
        }
    }
}
