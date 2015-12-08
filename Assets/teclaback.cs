using UnityEngine;
using System.Collections;
using MaterialUI;

public class teclaback : MonoBehaviour {
	public ScreenManager screenm;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			screenm.Back();
		}
		if(Input.GetKeyDown(KeyCode.Backspace)){
			screenm.Back();
		}
	}
}
