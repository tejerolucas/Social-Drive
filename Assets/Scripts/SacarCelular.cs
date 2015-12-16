using UnityEngine;
using System.Collections;
using MaterialUI;

public class SacarCelular : MonoBehaviour {
	public ScreenManager screenm;
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Menu)){
			screenm.Set("Celular");
		}
		#if UNITY_EDITOR
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("SACO");
			screenm.Set("Celular");
		}
		#endif
	}
}
