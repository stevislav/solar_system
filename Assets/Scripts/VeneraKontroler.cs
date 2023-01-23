using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeneraKontroler : MonoBehaviour {

    public float radius = 21.69f;
    public float speed = 0.588f;

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
			ZoomTarget.target_tag = 2;
			TimeScale.header = "Venera";
			TimeScale.info = "Masa: 4.87 * 10^24 kg\nPrečnik: 12104 km\nGravitacija: 8.9 m/s^2\nRastojanje od sunca: 108.2 * 10^6 km";
		}
	}
}
