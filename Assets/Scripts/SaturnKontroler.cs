using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnKontroler : MonoBehaviour {

    public float radius = 138f;
    public float speed = 0.016f;

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
			ZoomTarget.target_tag = 7;
			TimeScale.header = "Saturn";
			TimeScale.info = "Masa: 568.32 * 10^24 kg\nPrečnik: 116460 km\nGravitacija: 10.44 m/s^2\nRastojanje od sunca: 1.4 * 10^9 km";
		}
	}
}
