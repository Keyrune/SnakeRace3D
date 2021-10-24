using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public Color color;

    private void OnTriggerEnter(Collider other) 
    {
        
        if ( other.CompareTag("Player"))
            FindObjectOfType<SnakeMovement>().AddTail();
        Destroy(gameObject);
    }
}
