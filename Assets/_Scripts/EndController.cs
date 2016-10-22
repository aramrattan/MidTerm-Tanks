/// <summary>
/// End controller.
/// Arlina Ramrattan
/// 300799246
/// Last Modified by: A.R.
/// Date last modified: October 22, 2016
/// This program is a 2D top down scroller. The plyer is a green tank and they have to try and avoid the red enemy tanks. They have 5 lives. 
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndController : MonoBehaviour {

	public Button RestartButton;
	public GameController gameController;

	public Text FinalScoreLbl;




	// Use this for initialization
	void Start () {
		Debug.Log (this.gameController.FinalScore);
		this.FinalScoreLbl.text = "Final Score: " + this.gameController.FinalScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RestartButton_Click(){
		SceneManager.LoadScene ("Game");
	}
}
