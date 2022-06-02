using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Botao : MonoBehaviour
{

    public GameObject[] grupos;
    public string valor;
    public bool isFull;
    public int index;

    void Start()
    {
        valor = null;
    }
}