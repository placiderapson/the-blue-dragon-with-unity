using UnityEngine;

public class Jump : MonoBehaviour
{
    // Initialize the field
    public Vector2 JumpForce;

    // Jumping the blue dragon whenever left-clicked or spacebar key is pressed and play the jump sound at the same time
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
