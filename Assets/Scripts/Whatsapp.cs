using UnityEngine;
using System.Collections;

public class Whatsapp : MonoBehaviour {
	public Texture screen;
	public Texture background;
	public Color col; 

	void OnGUI(){
		GUI.color=col;
		//GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),screen);
		GUILayout.BeginArea(new Rect(0,0,Screen.width,500));
		GUILayout.EndArea();
		GUILayout.Label("Carg");
	}
}
