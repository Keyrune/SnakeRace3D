using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public Color color = Color.yellow;


    private void Awake() 
    {
        GetComponent<ColorController>().ChangeCollor(color);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (!other.CompareTag("Player")) return;
        if (other.GetComponent<SnakeMovement>().snakeColor != color) return;

        FindObjectOfType<SnakeMovement>().AddTail();
        Destroy(gameObject);
    }
}
