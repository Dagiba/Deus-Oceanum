using UnityEngine;
using System.Collections;

public class MovingShark : MonoBehaviour {

	public float speed;



	// Use this for initialization
	void Start () {
		transform.Translate (0, -speed * Time.deltaTime, 0);
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, -speed * Time.deltaTime, 0);
	
	}
}
