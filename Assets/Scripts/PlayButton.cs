using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PlayGame button clicked");

        SceneManager.LoadScene(1);
    }
}
