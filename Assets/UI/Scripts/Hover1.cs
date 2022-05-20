using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover1 : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform Button;
    void Start()
    {
        Button.GetComponent<Animator>().Play("Hoveroff1");
    }

    public void OnPointerEnter(PointerEventData eventData){
        Button.GetComponent<Animator>().Play("Hover1");
    }

    public void OnPointerExit(PointerEventData eventData){
        Button.GetComponent<Animator>().Play("Hoveroff1");
    }

}
