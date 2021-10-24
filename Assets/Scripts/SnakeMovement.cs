using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {

	public float speed = 2.0f;
	public float rotationSpeed = 180.0f;
	
	public List<GameObject> tailObjects = new List<GameObject>();
	public GameObject tailPrefab;

	public Text scoreText;
	public int scoreNumber = 0;
    private Vector3 cameraOffset;
    public Color snakeColor = Color.red;


	// Use this for initialization
	void Start () 
    {
		tailObjects.Add(gameObject);
        cameraOffset = transform.position - Camera.main.transform.position ;

	}
	

	// Update is called once per frame
	void Update () 
    {
		Move();
	}

	public void AddTail()
    {   
		Vector3 newTailPosition = tailObjects[tailObjects.Count-1].transform.position;
        GameObject newTail = GameObject.Instantiate(tailPrefab, newTailPosition, Quaternion.identity);
        newTail.GetComponent<Renderer>().material.color = snakeColor;
		tailObjects.Add(newTail);


        // Update score
		scoreNumber++;
        scoreText.text = scoreNumber.ToString();
	}

    private void Move()
    {
        Vector3 newPosition = Vector3.forward;
        newPosition = transform.position;

        // move forward
        newPosition.z = transform.position.z + speed * Time.deltaTime;

        // horizontal movement
        float posX = 0f;
        Vector3 touchPos = Input.mousePosition;
        Ray mRay = Camera.main.ScreenPointToRay(touchPos);
        if (mRay.direction.z != 0)
            posX = cameraOffset.magnitude * mRay.direction.x;
        newPosition.x = posX;
        
        transform.position = newPosition;

    }

    public void ChangeCollor(Color color)
    {
        snakeColor = color;
        foreach (GameObject tailPart in tailObjects)
        {
            tailPart.GetComponent<Renderer>().material.color = color;
        }
    }

}