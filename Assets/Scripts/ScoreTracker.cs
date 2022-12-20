using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
public class ScoreTracker : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] int score;

    private float startPosY = 0f;
    private float highestPosY = 0f;
    public UnityEvent<int> onScoreChange;


    // Start is called before the first frame update
    void Start()
    {
        startPosY = playerTransform.position.y;
        onScoreChange.Invoke(score);

    }

    // Update is called once per frame
    void Update()
    {
        float currentPosY = playerTransform.position.y;
        if (currentPosY > highestPosY)
        { highestPosY = currentPosY; }
        score = CalcScore();
        onScoreChange.Invoke(score);
     
    }
    private int CalcScore()
    {

        float scoreDistance = (highestPosY - startPosY)*10;
        return (int)scoreDistance;
    }
}
