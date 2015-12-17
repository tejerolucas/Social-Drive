using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MaterialUI;

public class ManagerGame : MonoBehaviour {
	public static float velocidad;
	public static bool jugando;
	public GameObject auto;
	public EZAnim derecha;
	public EZAnim izquierda;
	public static bool celular;
	private float delaymin;
	private float delaymax;
	public ManagerCelular mancelular;
	public ScreenManager screenmanager;
	public float gasmaximo;
	public float gas;
	public Image nivelgas;
	private AsyncOperation async;
	public static int monedas;
	public EZAnim showgasanim;
	public EZAnim hidegasanim;

	void Start(){
		monedas = 0;
		delaymin=5;
		delaymax=10;
		celular=false;
		gasmaximo = 100;
	}

	public void Acelerar () {
		gas = gasmaximo;
		jugando=true;
		iTween.ValueTo(this.gameObject,iTween.Hash("time",1.5f,"from",0,"to",100,"onupdatetarget",this.gameObject,"onupdate","acelerando"));
		float delay=Random.Range(delaymin,delaymax);
		Invoke("SendButton",delay);
	}

	void SendButton(){
		if(ManagerGame.jugando){
			if(!ManagerCelular.jugando){
				float delay=Random.Range(delaymin,delaymax);
				Invoke("SendButton",delay);
				mancelular.Boton(0);
			}
		}
	}



	public void Derecha(){
		Vector3 pos=Vector3.zero;
		if(auto.transform.position.z<-6){
			pos.z=10;
		}else{
			pos.z=32;
		}
		derecha.SetTarget0(pos);
		derecha.AnimateAll();
	}

	public void Izquierda(){
		Vector3 pos=Vector3.zero;
		if(auto.transform.position.z<11){
			pos.z=-7;
		}else{
			pos.z=10;
		}
		izquierda.SetTarget0(pos);
		izquierda.AnimateAll();
	}

	public void Pausa(){
		jugando = false;
		ManagerCelular.pausa=true;
		Invoke ("cambiarpausa",0.5f);
	}

	void cambiarpausa(){
		screenmanager.Set("Pausa");

	}

	void acelerando(float valor){
		velocidad=valor;
	}

	void perdistegas(){
		StartCoroutine("load");
		Invoke("fin",1.1f);
	}

	public void showgas(){
		showgasanim.AnimateAll ();
	}

	public void hidegas(){
		hidegasanim.AnimateAll ();
	}

	IEnumerator load() {
		Debug.LogWarning("ASYNC LOAD STARTED - " +
		                 "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
		async = Application.LoadLevelAsync("ruta");
		async.allowSceneActivation = false;
		yield return async;
	}
	
	void fin(){
		PlayerPrefs.SetString("perdio","gas");
		screenmanager.Set("Fin");
	}

	void Update(){
		if (jugando) {
			gas -= Time.deltaTime;
			nivelgas.fillAmount=gas/gasmaximo;
			if(gas<=0){
				if(screenmanager.currentScreen.name=="Celular"){
					screenmanager.currentScreen.Hide();
					screenmanager.Set("Game");
				}
				iTween.ValueTo(this.gameObject,iTween.Hash("time",1.5f,"from",100,"to",0,"onupdatetarget",this.gameObject,"onupdate","acelerando","oncompletetarget",this.gameObject,"oncomplete","perdistegas"));
			}
		}
	}

	public void Frenar () {
		jugando=false;
		velocidad=0;
	}
}
