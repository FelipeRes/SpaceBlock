using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float velocity;
	public GameObject projectil;
	public GameObject explosion;
	public Transform direction;
	public Vector3 dirPoint;
	public static int points;
	public static Player instance;
	public GameObject endPainel;

	void Start(){
		Player.points = 0;
		Player.instance = this;
	}

	void Update () {
		this.transform.Translate (Input.GetAxis ("Horizontal")*Time.deltaTime*velocity, Input.GetAxis ("Vertical")*Time.deltaTime*velocity, 0);
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (projectil, this.transform.position,Quaternion.identity);
		}

	}

	void OnCollisionEnter2D(Collision2D coll){
		this.gameObject.SetActive (false);
		GameObject explode = Instantiate (explosion, this.transform.position, Quaternion.identity) as GameObject;
		Destroy (explode,5);
		Invoke ("End", 5);
	}
	void End(){
		endPainel.SetActive (true);
	}

}
