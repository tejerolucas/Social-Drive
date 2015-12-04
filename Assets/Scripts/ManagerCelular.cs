using UnityEngine;
using System.Collections;

public class ManagerCelular : MonoBehaviour {
	public Color colorfinal;
	public CanvasGroup timerclock;
	public timer timerscript;
	public static int cantidad;
	public static int cantidadestados;
	public float tiempo;
	public static float tiempoamount;
	public GameObject[] redessociales;
	private GameObject red;
	public static bool jugando;

	void Awake () {
		cantidadestados=cantidad;
		jugando=false;
	}
	
	public void Gane(){
		iTween.Stop();
		jugando=false;
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",0.3,"onupdatetarget",this.gameObject,"onupdate","canvasalpha"));
	}

	public void settimer(string valor){
		Debug.Log("SET");
		float resultado;
		bool result=float.TryParse(valor,out resultado);
		tiempo=resultado;
	}
	
	void timer(float valor){
		tiempoamount=valor;
	}

	void terminotiempo(){
		iTween.Stop();
		Debug.Log(tiempo);
		Debug.Log("SIN TIEMPOOOOO");
		jugando=false;
		Application.LoadLevel("perdiste");
	}

	void iniciartimer(){
		Debug.Log("INICIAR TIMER");
		Debug.Log(tiempo);
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",tiempo,"onupdatetarget",this.gameObject,"onupdate","timer","oncompletetarget",this.gameObject,"oncomplete","terminotiempo"));
	}

	void canvasalpha(float valor){
		timerclock.alpha=valor;
		red.GetComponent<CanvasGroup>().alpha=valor;
	}

	public void Boton(int go){
        Debug.Log("BOTON JUGANDO");
		jugando=true;
		tiempoamount=1;
		red=redessociales[go];
		timerscript.red(go);
		red.GetComponent<SocialManager>().CrearEstados();
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",1,"time",0.3,"onupdatetarget",this.gameObject,"onupdate","canvasalpha","oncompletetarget",this.gameObject,"oncomplete","iniciartimer"));
	}
}
