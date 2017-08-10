using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HttpRequest : MonoBehaviour {

	public string Name;
	public string Value;
	public string Category;

	public void Submit(string name, string value){
		string url = "http://localhost:5000/insert";
		url += "/" + Category;
		url += "/" + name;
		url += "/" + value;
		WWW link = new WWW(url);
		StartCoroutine(WaitForRequest(link));
	}

	IEnumerator WaitForRequest(WWW www){
		Debug.Log (www);
		yield return www;
		if (www.error == null){
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}
		Application.LoadLevel (0);
	}
}
