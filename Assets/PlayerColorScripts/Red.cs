using UnityEngine;
using System.Collections;

public class Red : MonoBehaviour {
	public GameObject player;	
	public bool red;
	
	public void ChaneToRed () {
		player.renderer.material.color = Color.red;
		red = true;
	}
	
	public void ChangeToBlack () {
		player.renderer.material.color = Color.black;
		red = false;
	}
}