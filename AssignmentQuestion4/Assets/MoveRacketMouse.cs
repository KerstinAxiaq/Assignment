using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacketMouse : MonoBehaviour {

	public float speed = 30;
	public string axis = "Mouse Y";

	void FixedUpdate () {
		float v = Input.GetAxisRaw(axis);
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
}
