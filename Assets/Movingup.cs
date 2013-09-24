using UnityEngine;
using System.Collections;

public class Movingup : MonoBehaviour {
	float inittimer = 0.0f;
	bool buttonpush = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (buttonpush == true && Time.time < inittimer + 10f){
			transform.position += new Vector3( 0f, 1f * Time.deltaTime, 0f );
		}
	}
	
	void OnTriggerEnter() {
		inittimer = Time.time;
		//if (Time.time < inittimer+ 7f){
		buttonpush = true;
		//}
			
	}
}