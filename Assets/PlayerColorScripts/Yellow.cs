using UnityEngine;
using System.Collections;

public class Yellow : MonoBehaviour {
		public GameObject player;	
		public bool yellow;
		
		public void ChangeToYellow () {
			player.renderer.material.color = Color.yellow;
			yellow = true;
		}
		
		public void ChangeToBlack () {
			player.renderer.material.color = Color.black;
			yellow = false;
		}
	}
