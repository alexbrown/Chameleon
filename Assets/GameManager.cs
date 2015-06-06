using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int blockCount;
	public string score;
	public Text Count;
	public int highscore;
	public string hscore;
	public Text hiscore;
	// Use this for initialization
	void Start () {
		blockCount = 0; 
		highscore = PlayerPrefs.GetInt ("Highscore");
	}
	
	// Update is called once per frame
	void Update () {
		score = blockCount.ToString ();
		Count.text = score;

		hscore = highscore.ToString ();
		hiscore.text = hscore;

		PlayerPrefs.SetInt ("Score", blockCount);
		PlayerPrefs.Save ();


		if (blockCount > highscore) {
						PlayerPrefs.SetInt ("Highscore", blockCount);
						PlayerPrefs.Save ();
				}
	}

	void OnTriggerEnter(Collider other){
		blockCount++;
	}
}
