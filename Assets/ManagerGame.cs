using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MaterialUI;

public class ManagerGame : MonoBehaviour {
	public static float velocidad;
	public static bool jugando;
	public Text kilometrostxt;
	private float kilometros;
	public GameObject auto;
	public EZAnim derecha;
	public EZAnim izquierda;

	public void Acelerar () {
		jugando=true;
		iTween.ValueTo(this.gameObject,iTween.Hash("time",1.5f,"from",0,"to",100,"onupdatetarget",this.gameObject,"onupdate","acelerando"));
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
	}

	void acelerando(float valor){
		velocidad=valor;
	}

	void Update(){
		if(jugando){
			kilometros+=velocidad/100000;
			kilometrostxt.text=((int)kilometros).ToString()+" Kms";
		}
	}
	// Update is called once per frame
	public void Frenar () {
		jugando=false;
		velocidad=0;
	}
}
