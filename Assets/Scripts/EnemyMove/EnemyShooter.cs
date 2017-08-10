using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {

	public GameObject projectil;
	public float time;
	// Use this for initialization
	void Start () {
		Shoot ();
	}
	
	void Shoot(){
		Invoke ("Shoot", time);
		Instantiate (projectil, this.transform.position,Quaternion.identity);
	}
}
