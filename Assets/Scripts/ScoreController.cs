using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;


    // Update is called once per frame
    void Update()
    {
        if(scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            Debug.Log("Game Won");
        }


    }

    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = scorePlayer1.ToString();

        TextMeshProUGUI uiScorePlayer2 = scoreTextPlayer2.GetComponent<TextMeshProUGUI>();
        uiScorePlayer2.text = scorePlayer2.ToString();

    }


    public void GoalPlayer1()
    {
        scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        scorePlayer2++;
    }

}
