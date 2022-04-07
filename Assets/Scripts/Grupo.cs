using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Grupo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
 {
    public enum Resposta { A1, A2, B, C, D1, D2, E }
    public Resposta valor;
    public bool selected;
    
    public void OnSelect(BaseEventData eventData){
        GetComponent<Outline>().enabled = true;
        selected = true;
    }

    public void OnDeselect(BaseEventData eventData){
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

