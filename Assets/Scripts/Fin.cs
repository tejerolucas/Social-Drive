using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {
	public AsyncOperation async;

	void OnEnable(){
		if(async!=null){
			Debug.Log("ASYNC "+async.progress.ToString());
		}else{
			StartCoroutine("load");
		}
		Debug.Log("RELOAD SCENE");

		ManagerGame.jugando=false;
		ManagerCelular.jugando=false;
	}

	IEnumerator load() {
		Debug.LogWarning("ASYNC LOAD STARTED - " +
		                 "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
		async = Application.LoadLevelAsync("ruta");
		async.allowSceneActivation = false;
		yield return async;
	}
	// Use this for initialization
	public void boton () {
		async.allowSceneActivation=true;
	}

}
