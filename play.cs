using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	/*void OnMouseDown () {
		SceneManager.LoadScene("Fase1");
	}*/
	// Update is called once per frame

	public void Click () {
		SceneManager.LoadScene("fase1");
	}
		/*if (Input.GetMouseButtonDown (1) = "play") {
			Application.LoadLevel(1);
		}*/
	//}
}
