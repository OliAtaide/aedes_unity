using UnityEngine;

public class GameStart : MonoBehaviour {
    public GameObject Intro, Jogo, Feedback, Pontuacao, BotaoVerificar, BotaoFeedback, BotaoTentarNovamente;
    private void Start() {
        Intro.SetActive(true);
        Jogo.SetActive(false);
        Feedback.SetActive(false);
        Pontuacao.SetActive(false);
        BotaoVerificar.SetActive(true);
        BotaoFeedback.SetActive(true);
        BotaoTentarNovamente.SetActive(false);
    }
}