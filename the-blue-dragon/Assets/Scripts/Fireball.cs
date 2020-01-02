using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;

    // Update is called once per frame
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 2);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }
}
 