using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour {

	public Rigidbody2D Bird;

	// Use this for initialization
	void Start () {
		Bird = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) ) {
			Bird.velocity = new Vector2 (0, 5);
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Pipes") {

			//Destroy (gameObject);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}

	}
}


