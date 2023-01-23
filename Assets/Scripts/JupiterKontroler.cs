using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterKontroler : MonoBehaviour {

    public float radius = 77f;
    public float speed = 0.022f;

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
			ZoomTarget.target_tag = 6;
			TimeScale.header = "Jupiter";
			TimeScale.info = "Masa: 1.898 * 10^24 kg\nPrečnik: 139820 km\nGravitacija: 24.79 m/s^2\nRastojanje od sunca: 778 * 10^6 km";
		}
	}
}
