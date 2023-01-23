using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsKontroler : MonoBehaviour {

    public float radius = 45.72f;
    public float speed = 0.4f;

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
			ZoomTarget.target_tag = 4;
			TimeScale.header = "Mars";
			TimeScale.info = "Masa: 0.642 * 10^24 kg\nPrečnik: 6792 km\nGravitacija: 3.7 m/s^2\nRastojanje od sunca: 227.9 * 10^6 km";
		}
	}
}
