using UnityEngine;
using System.Collections;

public class Triggerscript3 : MonoBehaviour {

  bool active;
  // Use this for initialization
  void Start () {
    active = true;
  }

  void print1()
  {
    active = false;
    StartCoroutine(DialogScript.DialogueStart("3", gameObject));
  }

  // Update is called once per frame
  void Update () {

    transform.Rotate(0,1.0F,0);
  }

  void OnTriggerEnter(Collider other) {
    if(active)
      print1();
    
    //DialogScript.DialogueStart();

  }

}
