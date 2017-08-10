using UnityEngine;
using System.Collections;

public class Projectil : MonoBehaviour {

	public int damage;
	public float velocity;
	public GameObject hit;
	public Vector2 direction;

	void FixedUpdate () {
		this.transform.Translate (Time.deltaTime*velocity*direction);
		Destroy (this.gameObject, 4);
	}
	void OnTriggerEnter2D(Collider2D coll){
		Destroy (this.gameObject);
		GameObject explode = Instantiate (hit, this.transform.position, Quaternion.identity) as GameObject;
		Destroy (explode, 1);
	}	
}
