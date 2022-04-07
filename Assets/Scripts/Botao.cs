using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Botao : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    
    public GameObject [] grupos;
    public void OnPointerEnter(PointerEventData pointerEventData){
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData){
        GetComponent<Outline>().enabled = false;
    }

    public void MarcarResposta(){
        grupos = GameObject.FindGameObjectsWithTag("Grupo");
        foreach (var grupo in grupos)
        {
            if (grupo.GetComponent<Grupo>().selected)
            {
                Debug.Log(grupo);
            }
        }
    }
}