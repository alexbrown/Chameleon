using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {

	public bool dead;
	public GameObject player;
	public GameObject combo;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.transform.tag == "Blue") {
			if (player.GetComponent<Blue>().blue){

			} else {
				Die ();

			}
			if (combo.GetComponent<Green>().green){
				Die ();
			}
		}
		if (other.transform.tag != "Blue") {

		}
		if (other.transform.tag == "Red") {
			if (player.GetComponent<Red>().red){
			} else {
				Die ();
			}
		}
		if (other.transform.tag != "Red") {

		}
		if (other.transform.tag == "Green") {
			if (combo.GetComponent<Green>().green){


			} else {
				Die ();
			}
		}
		if (other.transform.tag != "Green") {

		}
		if (other.transform.tag == "Yellow") {
			if (player.GetComponent<Yellow>().yellow){
			
			}else {
				Die ();
			}
			if (combo.GetComponent<Green>().green){
				Die ();
			}

		}
		if (other.transform.tag != "Yellow") {

		}
	}
	
	  void Die() {
		Application.LoadLevel (2);
	}
}

