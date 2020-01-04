using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;

    // Method initializing the fireball velocity and destroying it whenever it goes out of the screen view port
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 2);
    }

    // Method for killing the red dragon whenever the fireball collides with them and destroying the fireball after killing the red dragon
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }
}
 