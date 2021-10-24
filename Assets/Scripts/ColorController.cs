using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{

    public void ChangeCollor(Color color)
    {
        //Get the Renderer component from the new cube
        GetComponent<Renderer>().material.color = color;

    }


}
