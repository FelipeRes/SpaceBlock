using UnityEngine;
using System.Collections;

public class EnemyVelocity : MonoBehaviour {

	public int velocity;
	void Update () {
		this.transform.Translate(-0.016f*velocity, 0,0);
	}
}
