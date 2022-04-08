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
            string texto = criadouros[0].texto;
            slot.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = texto;
            // slot.transform.GetChild(1).GetComponent<Botao>().valor = criadouros[0].resposta.ToString();
            GameObject obj = Instantiate(slot, transform.position, transform.rotation);
            obj.transform.SetParent(transform, false);
        }
    }

    public bool todasRespondidas(){
        for (int i = 0; i < criadouros.Count; i++)
        {
            if (transform.GetChild(i).GetChild(1).GetComponent<Botao>().valor == null)
            {
                return false;
            }
        }
        return true;
    }

    public void ChecarRespostas(){
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
                else{
                    child.GetComponent<Image>().color = new Color32(255, 64, 64, 255);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
