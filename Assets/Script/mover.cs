using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	public float speed = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveOBstacle ();
	}

	void MoveOBstacle() {

		transform.Translate (-speed * Time.deltaTime, 0, 0);

	}
}
