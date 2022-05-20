using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingButtonImage : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    private bool isOn = true;
    private Sprite soundOn;
    public Sprite soundOff;
    public Button button;
    void Start()
    {
        soundOn = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButton()
    {
        if (isOn){
             button.image.sprite = soundOff;
             isOn = false;
             audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOn;
            isOn=true;
            audioSource.mute = false;
        }
       
    }
}
