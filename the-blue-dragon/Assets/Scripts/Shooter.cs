using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Update is called once per frame
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
