using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Grupos : MonoBehaviour
{
    public static List<GameObject> GrupoObjects = new List<GameObject> { };
    public GameObject slot;
    public List<string> valores;
    public List<int> quants;

    void Start()
    {
        valores = new List<string> { "A1", "A2", "B", "C", "D1", "D2", "E" };
        quants = new List<int> { 1, 3, 4, 5, 2, 5, 3 };
        for (int i = 0; i < valores.Count; i++)
        {
            Grupo componente = slot.GetComponent<Grupo>();
            componente.valor = valores[i];
            componente.quantidade = quants[i];
            slot.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = valores[i];
            GameObject obj = Instantiate(slot, transform.position, transform.rotation);
            obj.name = valores[i];
            obj.transform.SetParent(transform, false);
            GrupoObjects.Add(obj);
        }
    }
}