using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Grupos : MonoBehaviour
{
    public enum Resposta { A1, A2, B, C, D1, D2, E }
    public Resposta valor;
    public GameObject slot;
    public List<string> grupos;
    public List<int> quants;

    void Start()
    {
        grupos = new List<string> { "A1", "A2", "B", "C", "D1", "D2", "E" };
        quants = new List<int> { 1, 3, 4, 5, 2, 5, 3 };
        for (int i = 0; i < grupos.Count; i++)
        {
            Grupo componente = slot.GetComponent<Grupo>();
            componente.valor = grupos[i];
            componente.quantidade = quants[i];
            slot.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = grupos[i];
            GameObject obj = Instantiate(slot, transform.position, transform.rotation);
            obj.transform.SetParent(transform, false);
        }
    }
}