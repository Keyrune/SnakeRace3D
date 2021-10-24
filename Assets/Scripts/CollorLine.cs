using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollorLine : MonoBehaviour
{   

    public Color color;


    private void Awake() 
    {
        GetComponent<Renderer>().material.color = color;
    }


    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<SnakeMovement>().ChangeCollor(color);
        }
    }

}
