using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject[] enemys;
	public float time;
	private int count;
	private Vector3 position;

	void Start () {
		Spawn ();	
	}

	void Spawn(){
		if (count == enemys.Length ) {
			count = 0;
		}
		position = new Vector3 (this.transform.position.x, Random.Range (-6, 6), 0);
		Instantiate (enemys [count], position, Quaternion.identity);
		Invoke ("Spawn", time);
		count++;
		if (time > 0.5f) {
			time -= Time.deltaTime;
		}
	}

}
