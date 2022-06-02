using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Grupos : MonoBehaviour
{
    public static List<GameObject> GrupoObjects = new List<GameObject> { };
    public Grupo componente;
    public GameObject slot;
    public List<string> valores;
    public List<int> quants;

    void Start()
    {
        gerarGrupos();
    }

    public void gerarGrupos()
    {
        valores = new List<string> { "A1", "A2", "B", "C", "D1", "D2", "E" };
        quants = new List<int> { 1, 3, 4, 5, 2, 5, 3 };

        for (int i = 0; i < valores.Count; i++)
        {
            criarGrupo(i);

            for (int j = 0; j < componente.quantidade; j++)
            {
                instanciarGrupo(i);
            }
        }
    }

    public void criarGrupo(int i)
    {
        componente = slot.GetComponent<Grupo>();
        componente.grupoList = GetComponent<Grupos>();
        componente.valor = valores[i];
        componente.quantidade = quants[i];
        componente.index = i;
        slot.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = valores[i];
    }

    public void instanciarGrupo(int i)
    {
        Transform child = transform.GetChild(i);
        GameObject obj = Instantiate(slot, new Vector3(0, 0, 0), transform.rotation);
        obj.name = valores[i];
        obj.transform.SetParent(child, false);
        GrupoObjects.Add(obj);
    }
}