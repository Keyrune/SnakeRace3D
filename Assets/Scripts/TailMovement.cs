using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

	public float speed;

	public GameObject tailTarget;
	public Vector3 tailTargetPosition;
	
	public SnakeMovement mainSnake;
	public int numberTarget;


	// Use this for initialization
	void Awake () {
		mainSnake = GameObject.FindWithTag("Player").GetComponent<SnakeMovement>();
		tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Count-1];

	}
	
	// Update is called once per frame
	void Update () {
		
		speed = mainSnake.speed;
		tailTargetPosition = tailTarget.transform.position;
		transform.LookAt(tailTargetPosition);
		transform.position = Vector3.Lerp(transform.position, tailTargetPosition, Time.deltaTime * speed);
	}

}