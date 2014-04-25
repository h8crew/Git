using UnityEngine;
using System.Collections;

public class BoxMove : MonoBehaviour {

	public GameObject cube;
	public Camera mainCamera;
	public float myFloat = 75f;
	
	void Start ()
	{
		cube.renderer.material.color = new Color(1f, 0f, 0f);
	}

	void Update ()
	{
		mainCamera.fieldOfView = myFloat;
	}
}
