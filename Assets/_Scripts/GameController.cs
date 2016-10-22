/// <summary>
/// Game controller.
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

public class GameController : MonoBehaviour {
	//PRIVATE INSTANCE VARIBLES
	private int _scoreValue = 0;
	private int _livesValue = 5; 
	private int _finalScore;
	//private AudioSource _gameOverSound;


	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

	public Text LivesLbl;
	public Text ScoreLbl;
	//End Scene
//	public Button RestartButton;
//
//	public Text FinalScoreLbl;
//	public Text GameOverlbl;



	public int FinalScore {
		get {
			return this._finalScore;
		}
		set {
			this._finalScore = value;
		}
	}

	public int ScoreValue {
		get {
			return this._scoreValue;
		}
		set {
			this._scoreValue = value;
			this.ScoreLbl.text = "Score: " + this._scoreValue;
		}

	}
	public int LivesValue {
		get {
			return this._livesValue;
		}
		set {
			this._livesValue = value;
			//this.LivesLbl.text = "Lives: " + this._livesValue;
			if (this._livesValue <= 0) {
				//this.FinalScore = this.ScoreValue;
				this._endGame ();
			} else {
				this.LivesLbl.text = "Lives: " + this._livesValue;
			}

		}
	}

	
	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
		this.ScoreLbl.text = "Score: " + _scoreValue;
		this.LivesLbl.text = "Lives: " + _livesValue;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void _endGame(){
		
		FinalScore = ScoreValue;
		Debug.Log (FinalScore);
		SceneManager.LoadScene ("End");
	}


	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}
}
