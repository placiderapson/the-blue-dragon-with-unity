using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{   
    // Initialize the field
    private float HeightVariance = 1f;

    // Make the dragons move in a wave form
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;
    }
}
