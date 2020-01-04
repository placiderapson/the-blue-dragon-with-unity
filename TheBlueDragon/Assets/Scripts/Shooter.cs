using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Initialize the field
    public GameObject projectilePrefab;

    // Method for shooting the fireball out of the blue dragon
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            var projectile = Instantiate(
                projectilePrefab,
                transform.position,
                projectilePrefab.transform.rotation);

            Physics2D.IgnoreCollision(projectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
