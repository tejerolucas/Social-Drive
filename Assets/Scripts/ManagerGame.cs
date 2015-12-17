using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MaterialUI;

public class ManagerGame : MonoBehaviour {
	public static float velocidad;
	public static bool jugando;
	public Text kilometrostxt;
	private float metros;
	public GameObject auto;
	public EZAnim derecha;
	public EZAnim izquierda;
	public static bool celular;
	private float delaymin;
	private float delaymax;
	public ManagerCelular mancelular;
	public ScreenManager screenmanager;

	public EZAnim showgasanim;
	public EZAnim hidegasanim;

	void Start(){
		delaymin=5;
		delaymax=10;
		celular=false;
	}

	public void Acelerar () {
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

	public void showgas(){
		showgasanim.AnimateAll ();
	}

	public void hidegas(){
		hidegasanim.AnimateAll ();
	}

	void Update(){
		if(jugando){
			metros+=velocidad/1000;
			if(metros>1000){
				kilometrostxt.text=((int)metros/1000).ToString()+" Kms";
			}else{
				kilometrostxt.text=((int)metros).ToString()+" Mts";
			}
		}
	}
	// Update is called once per frame
	public void Frenar () {
		jugando=false;
		velocidad=0;
	}
}
