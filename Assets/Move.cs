using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float moveSpeed;
	private Vector3 spawn;

	// Use this for initialization
	void Start () {
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Camera.main.transform);
	}

	void Die () {
		transform.position = spawn;
	}
}
