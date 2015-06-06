using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	
	public void Play () {
		Application.LoadLevel (1);
	}
	
	public void Replay () {
		Application.LoadLevel (1);
	}

	public void MMenu () {
		Application.LoadLevel (0);
	}
}

	

