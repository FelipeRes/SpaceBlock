using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsPainel : MonoBehaviour {

	public Text points;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		points.text = Player.points.ToString ();
	}
}
