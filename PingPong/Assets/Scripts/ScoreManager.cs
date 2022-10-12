using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text _score;

    void OnTriggerEnter2D(Collider2D other) {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball!=null)
        {
            score++;
            _score.text =""+score;
            ball.Point();
        }
    }
}
