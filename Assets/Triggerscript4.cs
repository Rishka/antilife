using UnityEngine;
using System.Collections;

public class Triggerscript4 : MonoBehaviour {

	bool active;

	// Use this for initialization
	void Start () {
		active = true;
	}

	void print4()
	{
		active = false;
		print ("Start trigger4");
		//print ("Hero presses the switch and sees the Robot base light up in the distance");
		print ("Hero talks about no survivors but to be careful of patrolling robots");
		StartCoroutine (DialogScript.DialogueStart ("4", gameObject));
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0,1.0F,0);
	}

	void OnTriggerEnter(Collider other) {
		if (active)
			print4 ();
		//Destroy(this.gameObject);
		print4();

		//DialogScript.DialogueStart();

	}

}
