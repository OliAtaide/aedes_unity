using UnityEngine;

public class GameStart : MonoBehaviour {
    public GameObject Intro, Jogo, Feedback;
    private void Start() {
        Intro.SetActive(true);
        Jogo.SetActive(false);
        Feedback.SetActive(false);
    }
}