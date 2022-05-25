using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{

    private int apples = 0;
    private int mushrooms = 0;

    public int applesToCollect = 0;
    public int mushroomsToCollect = 0;

    public GameObject enterText;
    public GameObject enterTextNotComp;

    public string levelToLoad;

    [SerializeField] private Text applesText;
    [SerializeField] private Text mushroomsText;

    private void Start()
    {
        enterText.SetActive(false);
        enterTextNotComp.SetActive(false);
    }

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
        if (collision.gameObject.CompareTag("Finish"))
        {

            if (apples == applesToCollect && mushrooms == mushroomsToCollect)
            {
                enterText.SetActive(true);

                Invoke("OnTriggerEnter", 1.0f);
                
                
                SceneManager.LoadScene(levelToLoad);
            }
            else
            {
                enterTextNotComp.SetActive(true);
            }
        }
    }

    
}
