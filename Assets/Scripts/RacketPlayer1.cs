using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * movementSpeed;
    }
}
