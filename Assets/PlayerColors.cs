using UnityEngine;
using System.Collections;

public class PlayerColors : MonoBehaviour {
	public Vector3 spawn;
	public bool blue;
	public bool yellow;
	public bool red;
	public bool green;
	public GUITexture redbutton;
	// Use this for initialization
	void Start () {
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

				if (redbutton.HitTest (Input.GetTouch (0).position)) {
			gameObject.renderer.material.color = Color.blue;
				}
				//Primary Colors
				if (blue) {
						gameObject.renderer.material.color = Color.blue;
				} else if (yellow) {
						gameObject.renderer.material.color = Color.yellow;
				} else if (red) {
						gameObject.renderer.material.color = Color.red;
				} else {
					gameObject.renderer.material.color = Color.black;
				}
				//Combo Colors
				if (green) {
						gameObject.renderer.material.color = Color.green;
				}
				if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D)){
						Die ();
				}
		}

	void Die (){
		transform.position = spawn;
	}
	
}
	