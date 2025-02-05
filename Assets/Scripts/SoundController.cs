using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            racketSound.Play();
            Debug.Log("RacketPlayer");
        }
        else
        {
            wallSound.Play();
            Debug.Log("Wall");
        }

    }
   
}
