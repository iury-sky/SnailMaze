using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class snailMov : MonoBehaviour {
	float vel = 1;

	Animator anim;

	[SerializeField]
	GameObject win,goal,snail;

	[SerializeField]
	Text timeTx;

	[SerializeField]
	AudioSource winSound,loseSound,gameSound;

	float time = 180f;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
		InvokeRepeating("DecreaseTime",1f,1f);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow))
		{
			anim.SetBool("Right", true);
			anim.SetBool("Left", false);
			anim.SetBool("Up", false);
			anim.SetBool("Down", false);
			transform.Translate (Vector3.right * Time.deltaTime*1);
		}
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			anim.SetBool("Right", false);
			anim.SetBool("Left", true);
			anim.SetBool("Up", false);
			anim.SetBool("Down", false);
			transform.Translate (Vector3.left * Time.deltaTime*1);
			//transform.Rotate ();
		}
		if (Input.GetKey (KeyCode.UpArrow))
		{
			anim.SetBool("Right", false);
			anim.SetBool("Left", false);
			anim.SetBool("Up", true);
			anim.SetBool("Down", false);
			transform.Translate (Vector3.up * Time.deltaTime*1);
			//transform.eulerAngles = new Vector3(0,0,90);
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			anim.SetBool("Right", false);
			anim.SetBool("Left", false);
			anim.SetBool("Up", false);
			anim.SetBool("Down", true);
			transform.Translate (Vector3.down * Time.deltaTime*1);
		}

		timeTx.text = time.ToString();

		if (time == 0)
		{
			Time.timeScale = 0;
			loseSound.Play();
			gameSound.Pause();
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "goal")
		{
			Time.timeScale = 0;
			win.SetActive(true);
			winSound.Play();
			gameSound.Pause();
		}
	}

	void DecreaseTime()
	{
		time -= 1;
	}
}
