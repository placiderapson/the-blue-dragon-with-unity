using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{

    // Kill the blue dragon whenever he goes beyond the screen view port or collides with the red dragons or stumps
    void Update()
    {
        if(transform.position.y > 5.75)
        {
            SceneManager.LoadScene(0);
        }

        if (transform.position.y < -5.75)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
