using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour {
	////Vector3 RotateOne = new Vector3(41.26958f, 79.15352f, 353.9402f);
	//Vector3 RotateTwo = new Vector3(85.96565f, 32.79916f, 29.55743f);
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.time > 0f && Time.time<10f){
			transform.position = new Vector3 (-6.627264f, 11.19925f, 29.71595f);
			transform.eulerAngles = new Vector3 (41.26958f, 79.15352f, 353.9402f);
		}
	if (Time.time > 10f && Time.time < 21f){
			transform.position = new Vector3 (2.023893f, 15.68752f, 31.60769f);
			transform.eulerAngles = new Vector3 (85.96565f, 32.79916f, 29.55743f);
	}
	if (Time.time >21f && Time.time< 26f){
			transform.position = new Vector3 (3.941872f, 0.7041693f, 23.64085f);
			transform.eulerAngles = new Vector3 (0f, 297.9699f, 0f);
		}
	if (Time.time >26f && Time.time <36f){
			transform.position = new Vector3 (2.430168f, 11.72295f, 22.144f);
			transform.eulerAngles = new Vector3 (37.46997f, 257.9211f, 354.2665f);
		}
	if (Time.time >36f && Time.time <41f) {
			transform.position = new Vector3 (5.76675f, 4.237507f, -3.379424f);
			transform.eulerAngles = new Vector3 (15.67789f, 299.0196f, 1.610556f);
			}
	if (Time.time >41f && Time.time <53f) {
			transform.position = new Vector3 (8.649168f, 4.237507f, -5.927765f);
			transform.eulerAngles = new Vector3 (0f,272.1972f, 0f);
			}
				
}
}
