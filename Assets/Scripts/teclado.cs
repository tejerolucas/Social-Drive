using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class teclado : MonoBehaviour {
	public Text texto;
	public InputField input;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(TouchScreenKeyboard.visible){
			texto.text="SI";
		}else{
			texto.text="NO";
		}
	}
}
