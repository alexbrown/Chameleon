using UnityEngine;
using System.Collections;

public class Green : MonoBehaviour {

	public GameObject player;
	public bool green;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<Blue> ().blue && player.GetComponent<Yellow> ().yellow) {
			player.renderer.material.color = Color.green;	
			green =true;
		}
	}
}
