using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Blue : MonoBehaviour {
	public GameObject player;	
	public bool blue;

	public void ChangeToBlue () {
		player.renderer.material.color = Color.blue;
		blue = true;
	}

	public void ChangeToBlack () {
		player.renderer.material.color = Color.black;
		blue = false;
	}
}
