using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public GameObject BPanel;
	public GameObject IPanel;
	public GameObject thePanel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	} 

	public void credits () {
		Application.LoadLevel ("credits");
				
	}

	public void startgame () {
		Application.LoadLevel ("antilife");
	}

	public void instructions () {
		var currents = IPanel.transform.position;
		BPanel.transform.position = currents;
		IPanel.transform.position = thePanel.transform.position;
	}


	public void back () {

		var currentb = BPanel.transform.position;
		BPanel.transform.position = thePanel.transform.position;
		IPanel.transform.position = currentb;
	}
	public void endgame () {
		Application.Quit();
	}
}
