using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZemljaKlik : MonoBehaviour {

	// Inicijalizacija
	void Start () {
		
	}
	
	// Azuriraje jednom po frejmu
	void Update () {
		
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
			ZoomTarget.target_tag = 3;
			TimeScale.header = "Zemlja";
			TimeScale.info = "Masa: 5.97 * 10^24 kg\nPrečnik: 12756 km\nGravitacija: 9.8 m/s^2\nRastojanje od sunca: 149.6  * 10^6 km\n\nMesec:\nMasa: 0.073 * 10^24 kg\nPrečnik: 3475 km\nGravitacija: 1.6 m/s^2\nRastojanje od zemlje: 0.384 * 10^6 km";
		}
	}
}
