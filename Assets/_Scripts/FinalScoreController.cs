using UnityEngine;
using System.Collections;

public class FinalScoreController : MonoBehaviour {

	private int _finalScore;
	//public GameController gameController;

	public int FinalScore {
		get {
			return this._finalScore;
		}
		set {
			this._finalScore = value;
		}
	}
	// Use this for initialization
	void Start () {
		//this._finalScore = this.gameController.FinalScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
