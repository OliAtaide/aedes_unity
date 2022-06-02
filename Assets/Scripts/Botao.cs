using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Botao : MonoBehaviour
{

    public GameObject[] grupos;
    public string valor;
    public bool isFull;

    void Start()
    {
        valor = null;
    }
}