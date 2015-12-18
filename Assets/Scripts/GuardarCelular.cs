using UnityEngine;
using System.Collections;
using MaterialUI;

public class GuardarCelular : MonoBehaviour {
	public ScreenManager screenm;
	
	void Update () {
		if(ManagerGame.celular){
			if(Input.GetKeyDown(KeyCode.Escape)){
				accion();
			}
			#if UNITY_EDITOR
			if(Input.GetKeyDown(KeyCode.Backspace)){
				accion();
			}
			#endif
		}
	}

	void accion(){
		screenm.currentScreen.Hide();
		screenm.Back();
		ManagerGame.celular=false;
	}
}
