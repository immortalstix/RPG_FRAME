using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeCont : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRigidbody;

	private bool moving; //Checks if the object is moving or not.

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;

	public float timeToMove;

	private float timeToMoveCounter;

	private Vector3 moveDirection;


	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();

		//timeBetweenMoveCounter = timeBetweenMove;
		//timeToMoveCounter = timeToMove;

		timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeBetweenMove * 1.25f);
	}

	// Update is called once per frame
	void Update()
	{
		if (moving)
		{
			timeToMoveCounter -= Time.deltaTime; // Ticks down the counter by Time.deltaTime.
			myRigidbody.velocity = moveDirection;

			if (timeToMoveCounter < 0f)
			{
				moving = false; // If no more time to move, movement is false.
				//timeBetweenMoveCounter = timeBetweenMove;
				timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
			}

		}

		else
		{
			timeBetweenMoveCounter -= Time.deltaTime; // Ticks down the counter by Time.deltaTime.
			myRigidbody.velocity = Vector2.zero; // If time has expired, reduces all velocity in all directions to zero.

			if (timeBetweenMoveCounter < 0f)
			{
				moving = true;
				//timeToMoveCounter = timeToMove; // Resetting moveTimeCounter to default value.
				timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeBetweenMove * 1.25f);
				moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);


			}
		}
	}
}