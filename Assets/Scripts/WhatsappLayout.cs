using UnityEngine;
using System.Collections;

public class WhatsappLayout : MonoBehaviour {
	public Texture header;
	public Texture box;
	public TouchScreenKeyboard teclado;
	private Vector2 pos;
	void OnGUI () {
		GUI.DrawTexture(new Rect(0,0,1080,header.height),header);
		GUI.BeginGroup(new Rect(0,Screen.height-box.height,1080,box.height));
		GUI.DrawTexture(new Rect(0,0,1080,box.height),box);
		GUI.EndGroup();
	}

	void Update(){
		if(Input.touchCount==3){
			TouchScreenKeyboard.hideInput=true;
			teclado = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NamePhonePad,false,false,false,true,"");
		}
	}
}
