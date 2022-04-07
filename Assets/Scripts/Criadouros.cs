using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            GameObject obj = Instantiate(slot, transform.position, transform.rotation);
            obj.transform.SetParent(transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
