using UnityEngine;
using System.Collections;

public class setLightColor : MonoBehaviour {

	randomColor theColor;

	// Use this for initialization
	void Start () {
	
		theColor = this.GetComponentInParent<randomColor> ();
		this.GetComponent<SpriteRenderer> ().color = theColor.colors [theColor.selectedCol];
	}
	
	// Update is called once per frame
	void Update () {
	
		//Vector3 v = Camera.main.transform.position - transform.position;

		Vector3 v = GameObject.Find("Main Camera").transform.position - transform.position;
		
		v.x = v.z = 0.0f;
		
		transform.LookAt( GameObject.Find("Main Camera").transform.position - v ); 
		
		transform.Rotate(0,180,0);

	}
}
