using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreen : MonoBehaviour {
	public GUISkin skin;
	public int score;
	public string currentscore;
	public Text current;
	public int highscore;
	public string hiscore;
	public Text hidisplay;
	void Start (){
		score = PlayerPrefs.GetInt ("Score") - 1;
		if (score <0) {
			score = 0;
		}
		currentscore = score.ToString ();
		current.text = currentscore;
		highscore = PlayerPrefs.GetInt ("Highscore");
		hiscore = highscore.ToString ();
		hidisplay.text = hiscore;
	}

}
