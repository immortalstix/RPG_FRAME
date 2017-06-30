using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour {

	public GameObject followTarget;
	private Vector3 targetPos;
	public float moveSpeed;

	private static bool cameraExists;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		if (!cameraExists) 
		{
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		}  else {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		targetPos = new Vector3 (followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		// starting from, where we want to go to, how much movement we want (move speed * Time.deltaTime)
		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
