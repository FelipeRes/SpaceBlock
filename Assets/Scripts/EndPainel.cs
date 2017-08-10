using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndPainel : MonoBehaviour {

	public Text[] letras;
	public string[] Alfabeto;
	public int len;
	public int count;
	public int posLetra;
	public bool finished;
	public HttpRequest request;

	void Start () {
		len = letras.Length;
	}

	void Update () {
		if (!finished) {
			if (Input.GetKeyDown (KeyCode.S)) {
				count--;
				if (count < 0) {
					count = 25;
				}
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				count++;
				if (count > 25) {
					count = 0;
				}
			}
			letras [posLetra].text = Alfabeto [count];

			if (Input.GetMouseButtonDown (0)) {
				count = 0;
				posLetra++;
				if (posLetra >= len) {
					finished = true;
					string name = "";
					for (int i = 0; i < posLetra; i++) {
						name += letras [i].text;
					}
					Debug.Log (name);
					request.Submit (name, Player.points.ToString());
				}
			}
		}
	}
}
