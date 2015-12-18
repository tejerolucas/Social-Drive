using UnityEngine;
using System.Collections;
using MaterialUI;

public class AutoManager : MonoBehaviour {
	public Camera cam;
	public Transform[] poschoques;
	public ScreenManager screenmanager;
	public GameObject punta;
	public GameObject part;
	public EZAnim animacionGameOut;


	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision) {
		Debug.Log("HIT");
		if(screenmanager.currentScreen.name=="Celular"){
			screenmanager.currentScreen.Hide();
			screenmanager.Set("Game");
		}
		if (collision.gameObject.layer == 10) {
			PlayerPrefs.SetString("perdio","auto");
		}
		if (collision.gameObject.layer == 9) {
			PlayerPrefs.SetString("perdio","estacion");
		}
		animacionGameOut.AnimateAll();
		ManagerGame.velocidad=0;
		Transform trans=poschoques[Random.Range(0,poschoques.Length)];
		iTween.RotateTo(cam.gameObject,iTween.Hash("time",0.5f,"rotation",trans));
		iTween.MoveTo(cam.gameObject,iTween.Hash("time",0.2f,"position",trans,"oncomplete","particulas","oncompletetarget",this.gameObject));
	}

	void particulas(){
		Instantiate(part,punta.transform.position,this.transform.rotation);
		Invoke("fin",1.1f);
	}


	
	void fin(){
		screenmanager.Set("Fin");
	}
}
