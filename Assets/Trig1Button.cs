using UnityEngine;
using System.Collections;

public class Trig1Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(){
		transform.position += new Vector3( 0f, -0.2f, 0f);
		
	}
}
