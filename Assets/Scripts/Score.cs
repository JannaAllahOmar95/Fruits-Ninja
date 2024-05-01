using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit"))
        {
            score++;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        } 
        if (other.CompareTag("ScoreFruit"))
        {
            score += 2;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        }
        
    }
}