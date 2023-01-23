using UnityEngine;
using System.Collections;

public class TimeScale : MonoBehaviour {

    private float timeScale;

	public static string header = "Solarni sistem";
	public static string info = "Merkur\nVenera\nZemlja\nMars\nJupiter\nSaturn\nUran\nNeptun";

	public GUIStyle styleHeader;

    void OnGUI()
    {
		styleHeader.fontSize = 20;
		styleHeader.fontStyle = FontStyle.Bold;
		styleHeader.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 40, 100, 40), new GUIContent("Brzina simulacije"));
        timeScale = GUI.HorizontalSlider(new Rect(10, 60, 150, 60), timeScale, -4, 4);
        Time.timeScale = Mathf.Exp(timeScale);

		GUI.Label (new Rect (10, 100, 100, 30), new GUIContent(header), styleHeader);
		GUI.Label (new Rect (10, 120, 400, 400), new GUIContent(info));

		GUI.Label (new Rect (10, 20, 100, 20), new GUIContent("Stevan Popović"));
    }

}
