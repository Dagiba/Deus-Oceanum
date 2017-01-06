using UnityEngine;
using System.Collections;

public class movingCamera : MonoBehaviour {

	public float speed;



	// Use this for initialization
	void Start () {
		transform.Translate (0, 0, speed * Time.deltaTime);
	}

	// Update is called once per frame
	void Update () {

		transform.Translate (0, 0, speed * Time.deltaTime);

	}
}
