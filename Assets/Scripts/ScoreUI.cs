using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextMesh;

    public void SetScore(int score)
    {
        string text = "Score: " + score;
        TextMesh.text = text;

    }
   
        
  
}
