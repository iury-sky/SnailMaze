using UnityEngine;
using System.Collections;

public class snail : MonoBehaviour {
	double vel = 0.15;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime);
		//transform.position = new Vector2 (1*Time.deltaTime,0);
	}
}
