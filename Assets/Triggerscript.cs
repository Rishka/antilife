using UnityEngine;
using System.Collections;

public class Triggerscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void print1()
	{
          
          StartCoroutine(DialogScript.DialogueStart("1"));
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0,1.0F,0);
	}

	void OnTriggerEnter(Collider other) {
		Destroy(this.gameObject);
		print1();

		//DialogScript.DialogueStart();

	}

}
