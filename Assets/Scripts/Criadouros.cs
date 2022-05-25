using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Criadouros : MonoBehaviour
{
    public GameObject slot;
    public List<Criadouro> criadouros;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < criadouros.Count; i++)
        {
            string texto = criadouros[i].texto;
            slot.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = texto;
            GameObject obj = Instantiate(slot, transform.position, transform.rotation);
            obj.transform.SetParent(transform, false);
            obj.name = criadouros[i].texto;
        }
    }

    public bool todasRespondidas()
    {
        for (int i = 0; i < criadouros.Count; i++)
        {
            if (transform.GetChild(i).GetChild(1).GetComponent<Botao>().valor == null)
            {
                return false;
            }
        }
        return true;
    }

    public void ChecarRespostas()
    {
        if (todasRespondidas())
        {
            for (int i = 0; i < criadouros.Count; i++)
            {
                string respota = criadouros[i].resposta.ToString();
                Transform child = transform.GetChild(i).GetChild(1);
                if (respota == child.GetComponent<Botao>().valor)
                {
                    child.GetComponent<Image>().color = new Color32(64, 255, 64, 255);
                }
                else
                {
                    child.GetComponent<Image>().color = new Color32(255, 64, 64, 255);
                }
            }
        }
    }

    public void TentarNovamente()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Image img = child.GetChild(1).GetComponent<Image>();
            TextMeshProUGUI tmp = child.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            tmp.text = "";
            img.color = new Color32(246, 107, 59, 255);
        }

        foreach (var c in Grupos.GrupoObjects)
        {
            c.SetActive(true);
            c.GetComponent<Outline>().enabled = false;
        }
    }
}
