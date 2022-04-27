using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Grupo : MonoBehaviour, IPointerEnterHandler,
                    IPointerExitHandler,
                    IPointerClickHandler, IBeginDragHandler,
                    IDragHandler, IEndDragHandler
{
    public string valor;
    public bool selected, dragging;

    public GameObject[] grupos;

    public Vector3 initialPosition;
    public int quantidade, res;

    void Start()
    {
        initialPosition = transform.position;
        res = Screen.width;
    }

    void Update()
    {
        if (res != Screen.width)
        {
            initialPosition = transform.position;
            res = Screen.width;
        }
    }


    public void Deselect()
    {
        GetComponent<Outline>().enabled = false;
        selected = false;
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        GetComponent<Outline>().enabled = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (!selected)
        {
            GetComponent<Outline>().enabled = false;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData data)
    {
        transform.position = Input.mousePosition;
        grupos = GameObject.FindGameObjectsWithTag("Grupo");
        foreach (var grupo in grupos)
        {
            grupo.GetComponent<Grupo>().Deselect();
        }
        GetComponent<Outline>().enabled = true;
        dragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        GameObject criadouro = col.gameObject;

        if (criadouro.tag == "Criadouro" && !dragging)
        {
            criadouro.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
            criadouro.GetComponent<Botao>().valor = valor;
            quantidade--;
            if (quantidade == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = initialPosition;
            }
        }
    }

}

