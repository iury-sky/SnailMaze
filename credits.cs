using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Click () {
		SceneManager.LoadScene("credits");

	}
}
