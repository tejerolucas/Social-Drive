using UnityEngine;
using System.Collections;
using MaterialUI;

public class SacarCelular : MonoBehaviour {
	public ScreenManager screenm;
	
	void Update () {
		if(!ManagerGame.celular){

			if(Input.GetKeyDown(KeyCode.Menu)){
				accion();
			}
			#if UNITY_EDITOR
			if(Input.GetKeyDown(KeyCode.Space)){
				accion();
			}
			#endif
		}
	}

	void accion(){
		Debug.Log("SACO");
		screenm.Set("Celular");
		ManagerGame.celular=true;
		Debug.Log("CELULAR");
	}
}
