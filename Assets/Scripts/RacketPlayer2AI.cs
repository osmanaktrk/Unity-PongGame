using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour
{
    public float movementSpeed;

    public GameObject ball;

    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (this.transform.position.y < ball.transform.position.y)
            {
                this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 1) * movementSpeed;
            }
            else 
            {
                this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -1) * movementSpeed;
            }
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        }
    }
}
