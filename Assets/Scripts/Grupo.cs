using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Grupo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
 {
    public string valor;
    public bool selected;

    public GameObject [] grupos;
    
    public void OnSelect(BaseEventData eventData){
        grupos = GameObject.FindGameObjectsWithTag("Grupo");
        foreach (var grupo in grupos)
        {
            grupo.GetComponent<Grupo>().Deselect();
        }
        GetComponent<Outline>().enabled = true;
        selected = true;
    }

    // IDeselectHandler
    // public void OnDeselect(BaseEventData eventData){
    //     GetComponent<Outline>().enabled = false;
    //     selected = false;
    // }

    public void Deselect(){
         GetComponent<Outline>().enabled = false;
         selected = false;
    }
    public void OnPointerEnter(PointerEventData pointerEventData){
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData){
        if(!selected){
            GetComponent<Outline>().enabled = false;
        }
    }
    
}

