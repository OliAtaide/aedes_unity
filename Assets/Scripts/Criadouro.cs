using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Novo Criadouro", menuName = "Criadouro", order = 1)]
public class Criadouro : ScriptableObject
{
    public enum Resposta { A1, A2, B, C, D1, D2, E }
    public string texto;
    // public int resposta;
    public Resposta resposta;
    public bool isFull;
}
