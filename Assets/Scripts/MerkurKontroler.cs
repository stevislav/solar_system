using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerkurKontroler : MonoBehaviour {

    public float radius = 11.6f;
    public float speed = 0.8f;

    // Inicijalizacija
    void Start()
    {
    }

    // Azuriranje jednom po frejmu
    void Update()
    {
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
			TimeScale.header = "Solarni sistem";
			TimeScale.info = "Merkur\nVenera\nZemlja\nMars\nJupiter\nSaturn\nUran\nNeptun";
		} else {
			ZoomTarget.zoom = true;
			ZoomTarget.target_tag = 1;
			TimeScale.header = "Merkur";
			TimeScale.info = "Masa: 0.33 * 10^24 kg\nPrečnik: 4879 km\nGravitacija: 3.7 m/s^2\nRastojanje od sunca: 57.9 * 10^6 km";
		}
	}
}
