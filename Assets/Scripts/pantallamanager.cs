using UnityEngine;
using System.Collections;

public class pantallamanager : MonoBehaviour {
	public CanvasGroup go;
	public CanvasGroup manager;

	public void cambiar () {
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",1,"onupdatetarget",this.gameObject,"onupdate","managercanvas","oncompletetarget",this.gameObject,"oncomplete","prender"));
	}

	public void managercanvas(float valor){
		manager.alpha=valor;
	}

	public void otrocanvas(float valor){
		go.alpha=valor;
	}

	public void prender(){
		Debug.Log("PRENDER");
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",1,"time",1,"onupdatetarget",this.gameObject,"onupdate","otrocanvas"));
	}
}
