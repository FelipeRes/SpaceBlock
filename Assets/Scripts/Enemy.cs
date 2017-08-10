using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int vida;
	public GameObject particle;

	void Update(){
		if (vida <= 0) {
			Destroy (this.gameObject);
			GameObject explode = Instantiate (particle, this.transform.position, Quaternion.identity) as GameObject;
			Destroy (explode, 1);
			Player.points += 5;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		Player.points++;
		vida--;
	}
}
