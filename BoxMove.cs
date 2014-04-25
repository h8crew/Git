using UnityEngine;
using System.Collections;

public class BoxMove : MonoBehaviour {

	public Camera mainCamera;
	public float myFloat = 75f;

	void Update () {
		mainCamera.fieldOfView = myFloat;
	}
}
