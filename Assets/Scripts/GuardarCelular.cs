using UnityEngine;
using System.Collections;
using MaterialUI;

public class GuardarCelular : MonoBehaviour {
	public ScreenManager screenm;
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			screenm.Set("Game");
		}
#if UNITY_EDITOR
		if(Input.GetKeyDown(KeyCode.Backspace)){
			screenm.currentScreen.Hide();
			screenm.Set("Game");
		}
#endif
	}
}
