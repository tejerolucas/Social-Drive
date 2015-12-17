using UnityEngine;
using System.Collections;
using MaterialUI;

public class AutoManager : MonoBehaviour {
	public Camera cam;
	public Transform[] poschoques;
	public ScreenManager screenmanager;
	public GameObject punta;
	public GameObject part;
	public static AsyncOperation async;
	public EZAnim animacionGameOut;


	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
		if(screenmanager.currentScreen.name=="Celular"){
			screenmanager.currentScreen.Hide();
			screenmanager.Set("Game");
		}
		animacionGameOut.AnimateAll();
		ManagerGame.velocidad=0;
		Transform trans=poschoques[Random.Range(0,poschoques.Length)];
		iTween.RotateTo(cam.gameObject,iTween.Hash("time",0.7f,"rotation",trans));
		iTween.MoveTo(cam.gameObject,iTween.Hash("time",0.7f,"position",trans,"oncomplete","particulas","oncompletetarget",this.gameObject));
	}

	void particulas(){
		StartCoroutine("load");
		Instantiate(part,punta.transform.position,this.transform.rotation);
		Invoke("fin",1.1f);
	}

	IEnumerator load() {
		Debug.LogWarning("ASYNC LOAD STARTED - " +
		                 "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
		async = Application.LoadLevelAsync("ruta");
		async.allowSceneActivation = false;
		yield return async;
	}
	
	void fin(){
		screenmanager.Set("Fin");
	}
}
