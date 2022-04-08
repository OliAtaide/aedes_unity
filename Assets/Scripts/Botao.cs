using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Botao : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
    
    public GameObject [] grupos;
    public string valor;

    void Start() {
        valor = null;    
    }
    public void OnPointerEnter(PointerEventData pointerEventData){
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData){
        GetComponent<Outline>().enabled = false;
    }

    public void OnPointerClick(PointerEventData pointerEventData){
        grupos = GameObject.FindGameObjectsWithTag("Grupo");
        foreach (var grupo in grupos)
        {
            if (grupo.GetComponent<Grupo>().selected)
            {
                GetComponent<Image>().sprite = grupo.GetComponent<Image>().sprite;
                valor = grupo.GetComponent<Grupo>().valor;
            }
        }
    }
}