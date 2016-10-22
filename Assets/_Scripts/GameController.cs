using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	//PRIVATE INSTANCE VARIBLES
	private int _scoreValue = 0;
	private int _livesValue = 5; 
	//private AudioSource _gameOverSound;


	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

	public Text LivesLbl;
	public Text ScoreLbl;

	/// <summary>
	/// Gets or sets the score value. And displays it in the label
	/// </summary>
	/// <value>The score value.</value>
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
			this.LivesLbl.text = "Lives: " + this._livesValue;
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

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}
}
