using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Initialize the fields
    public float Speed = 1;
    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Method for moving the stumps and red dragons left and bringing them when they disappear
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

        if(transform.position.x < -15)
        {
            transform.position += new Vector3(33, 0, 0); 
            ShowRandomSprite();

            enemy?.Respawn();
        }
    }

    // Method for displaying the stumps randomly    
    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for(int count = 0; count < childCount; count++)
        {
            Transform child = transform.GetChild(count);
            bool shouldShow = index == count;
            child.gameObject.SetActive(shouldShow);
        }
    }

    // Invoking the random sprite method whenever the stump is active
    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
