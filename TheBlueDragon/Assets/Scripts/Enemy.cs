
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Method for killing the red dragons
    public void Die()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
    
    // Method for resurrecting the red dragons
    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
