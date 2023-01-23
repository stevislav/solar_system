using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptunKontroler : MonoBehaviour {

    public float radius = 300f;
    public float speed = 0.009f;

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
			ZoomTarget.target_tag = 9;
			TimeScale.header = "Neptun";
			TimeScale.info = "Masa: 102.409 * 10^24 kg\nPrečnik: 49244 km\nGravitacija: 11.15 m/s^2\nRastojanje od sunca: 4.5 * 10^9 km";
		}
	}
}
