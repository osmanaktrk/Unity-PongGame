using UnityEngine;

public class RackedPlayer2 : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        this.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * movementSpeed;
       
    }
}
