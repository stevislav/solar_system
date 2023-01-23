using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ZemljaKontroler : MonoBehaviour {

    public float radius = 34.0f;
    public float speed = 0.5f;
    public float selfSpeed = 12.0f;

    private Transform Zemlja;

	// Inicijalizacija
	void Start () {
        Zemlja = this.transform.Find("Zemlja");
	}
	
	// Azuriranje jednom po frejmu
	void Update () {
        Zemlja.Rotate(Vector3.up, Time.deltaTime * selfSpeed);
        this.transform.localPosition = GetPosition(Time.time * speed);

	}

    private Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }
		
	void OnMouseDown() {
		bool zoom = ZoomTarget.zoom;
		if (zoom) {
			ZoomTarget.zoom = false;
			ZoomTarget.target_tag = 0;
		} else {
			ZoomTarget.zoom = true;
			ZoomTarget.target_tag = 3;
		}
	}
}
