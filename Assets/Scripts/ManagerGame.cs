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
	public static int monedas;
	public Text monedastxt;
	public EZAnim showgasanim;
	public EZAnim hidegasanim;
	public Button gasbtn;
	private int valorgas;
	public Text valorgastxt;

	void Start(){
		monedas = 0;
		delaymin=20;
		delaymax=50;
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

				mancelular.Boton(0);
			}
			float delay=Random.Range(delaymin,delaymax);
			Debug.Log("DELAY "+delay.ToString());
			Invoke("SendButton",delay);
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

	public void cargargas(){
		if(valorgas<=monedas){
			monedas-=valorgas;
			valorgas=0;
			hidegas();
			gas=gasmaximo;
		}
	}


	public void showgas(int valor){
		if(valor<=monedas){
			valorgastxt.text=valor.ToString();
			showgasanim.AnimateAll ();
			gasbtn.enabled=true;
			valorgas=valor;
		}
	}

	public void hidegas(){
			gasbtn.enabled=false;
		hidegasanim.AnimateAll ();
		valorgas=0;
	}


	void fin(){
		PlayerPrefs.SetString("perdio","gas");
		screenmanager.Set("Fin");
	}

	void Update(){
		if (jugando) {
			monedastxt.text=monedas.ToString();
			gas -= Time.deltaTime/1.5f;
			nivelgas.fillAmount=gas/gasmaximo;
			if(gas<=0){
				if(screenmanager.currentScreen.name=="Celular"){
					screenmanager.currentScreen.Hide();
					screenmanager.Set("Game");
				}
				velocidad=0;
				fin ();
			}
		}
	}

	public void Frenar () {
		jugando=false;
		velocidad=0;
	}
}
