using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTarget : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	public static bool zoom = false;
	public static int target_tag = 0;
	public static string target_string = "Sunce";

	public float turnSpeed = 4.0f;		// Brzina kamere pri kretanju po osi
	public float panSpeed = 4.0f;		// Brzina kamere pri kretanju
	public float zoomSpeed = 4.0f;		// Brzina kamere pri zumiranju

	private Vector3 mouseOrigin;	// Pocetna pozicija kursora
	private bool isRotating;
	private bool isZooming;


	void Update () {
		// Levi klik
		if(Input.GetMouseButtonDown(0))
		{
			// Pozicija kursora
			mouseOrigin = Input.mousePosition;
			isRotating = true;
		}

		// Desni klik
		if(Input.GetMouseButtonDown(1))
		{
			// Pozicija kursora
			mouseOrigin = Input.mousePosition;
			isZooming = true;
		}

		// Prekid kretanja pri pustanju tastera misa
		if (!Input.GetMouseButton(0)) isRotating=false;
		if (!Input.GetMouseButton(1)) isZooming=false;

		// Rotiranje kamere
		if (isRotating)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
			transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
		}

		// Kretanje kamere po z osi
		if (isZooming)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			Vector3 move = pos.y * zoomSpeed * transform.forward; 
			transform.Translate(move, Space.World);
		}

		if (Input.GetMouseButton (0)) {
			if (zoom) {
				zoom = false;
				return;
			} else {
				zoom = true;
				return;
			}
		}
		if (Input.GetMouseButton (0)) {
			if (zoom) {
				zoom = false;
				target_tag = 0;
			}
		}

		if (target_tag == 0) {
			target = GameObject.Find ("Sunce").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1.5f, -5f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		} else if (target_tag == 1) {
			target = GameObject.Find ("Merkur").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 0.6f, -3f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 2) {
			target = GameObject.Find ("Venera").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 0.7f, -2.8f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 3) {
			target = GameObject.Find ("ZemljinSistem").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1f, -5f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 4) {
			target = GameObject.Find ("Mars").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 0.7f, -4f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 5) {
			target = GameObject.Find ("Mesec").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 0.1f, -2f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime / 10);
		}else if (target_tag == 6) {
			target = GameObject.Find ("Jupiter").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1.8f, -5f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 7) {
			target = GameObject.Find ("Saturn").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1.6f, -5f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 8) {
			target = GameObject.Find ("Uran").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1.2f, -4f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}else if (target_tag == 9) {
			target = GameObject.Find ("Neptun").transform;
			Vector3 targetPosition = target.TransformPoint (new Vector3 (0f, 1.2f, -4f));
			this.transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}
		   
        if (Input.GetKey("escape")){
                Application.Quit();
        }

		
	}

}
