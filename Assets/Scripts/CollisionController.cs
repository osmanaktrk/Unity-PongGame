
using UnityEngine;

public class CollisionController : MonoBehaviour
{

    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHight = collision.collider.bounds.size.y;

        float x;
        if(collision.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        ballMovement.IncreaseCounter();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            BounceFromRacket(collision);
        }else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with WallLeft");
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with WallRight");
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }
        
    }


}
