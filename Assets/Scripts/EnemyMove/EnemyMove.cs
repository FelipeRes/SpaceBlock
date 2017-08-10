using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public int velocity;
	void Update () {
		this.transform.position = Vector3.MoveTowards (this.transform.position, Player.instance.transform.position, 0.016f*velocity);
	}
}
