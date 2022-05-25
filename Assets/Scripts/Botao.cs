using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Botao : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject[] grupos;
    public string valor;
    public bool isFull;

    void Start()
    {
        valor = null;
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        GetComponent<Outline>().enabled = false;
    }
}