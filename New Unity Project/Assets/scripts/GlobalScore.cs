using UnityEngine;
using System.Collections;

public class GlobalScore : MonoBehaviour
{

    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreDisplay;

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "Score: " + InternalScore;
    }
}