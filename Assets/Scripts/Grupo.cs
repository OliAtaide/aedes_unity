using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Grupo : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public string valor;
    public bool used, dragging;

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
            initialPosition = GetComponent<RectTransform>().anchoredPosition;
            res = Screen.width;
        }
    }

    public void OnDrag(PointerEventData data)
    {
        transform.position = Input.mousePosition;
        grupos = GameObject.FindGameObjectsWithTag("Grupo");
        dragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        GameObject criadouro = col.gameObject;

        if (criadouro.tag == "Criadouro" && !dragging && !used)
        {
            Botao botao = criadouro.GetComponent<Botao>();

            criadouro.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = valor;
            criadouro.GetComponent<Botao>().valor = valor;

            Destroy(gameObject);

            used = true;

            botao.isFull = true;
        }

    }

}

