using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranKontroler : MonoBehaviour {

    public float radius = 227f;
    public float speed = 0.0115f;

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
			ZoomTarget.target_tag = 8;
			TimeScale.header = "Uran";
			TimeScale.info = "Masa: 86.811 * 10^24 kg\nPrečnik: 50724 km\nGravitacija: 8.87 m/s^2\nRastojanje od sunca: 2.87 * 10^9 km";
		}
	}
}
