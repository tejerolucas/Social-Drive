using UnityEngine;
using System.Collections;
using MaterialUI;

public class ManagerCelular : MonoBehaviour {

	public CanvasGroup timerclock;
	public timer timerscript;
	public static int cantidad;
	public static int cantidadestados;
	public float tiempo;
	public float tiempotemp;
	public static float tiempoamount;
	public GameObject[] redessociales;
	private GameObject red;
	public static bool jugando;
	public EZAnim animacionGameOut;
	public ScreenManager screenmanager;
	public static bool pausa;


	void Awake () {
		pausa=false;
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

	void Update(){
		if(jugando&&(!pausa)){
			tiempotemp-=Time.deltaTime;
			tiempoamount=tiempotemp/tiempo;
			if(tiempotemp<=0){
				terminotiempo();
			}
		}
	}

	public void resume(){
		pausa=false;
		iTween.Resume(this.gameObject);
	}

	void terminotiempo(){
		if(screenmanager.currentScreen.name=="Celular"){
			screenmanager.currentScreen.Hide();
			screenmanager.Set("Game");
		}
		PlayerPrefs.SetString("perdio","social");
		timerclock.alpha=0;
		ManagerGame.velocidad=0;
		iTween.Stop();
		Debug.Log(tiempo);
		Debug.Log("SIN TIEMPOOOOO");
		jugando=false;
		animacionGameOut.AnimateAll();
		Invoke("fin",1.1f);
	}

	void fin(){
		screenmanager.Set("Fin");
	}

	void iniciartimer(){
		Debug.Log("INICIAR TIMER");
		Debug.Log(tiempo);
		jugando=true;
	}

	void canvasalpha(float valor){
		timerclock.alpha=valor;
		red.GetComponent<CanvasGroup>().alpha=valor;
	}

	public void Boton(int go){
		tiempoamount=1;
		tiempotemp=tiempo;
		red=redessociales[go];
		timerscript.red(go);
		red.GetComponent<SocialManager>().CrearEstados();
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",1,"time",0.3,"onupdatetarget",this.gameObject,"onupdate","canvasalpha","oncompletetarget",this.gameObject,"oncomplete","iniciartimer"));
	}
}
