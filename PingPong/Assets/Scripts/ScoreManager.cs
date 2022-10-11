using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text _score;

    void OnTriggerEnter2D(Collider2D other) {
        score++;
        _score.text =""+score;
    }
}
