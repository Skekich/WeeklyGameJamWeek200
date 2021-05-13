using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpText;
    private int score = 0;

    private void Start() {
        tmpText.text = "Score: 0";
    }

    public void ShowScore(){
        score += 1;
        tmpText.text = "Score: " + score;
    }
}
