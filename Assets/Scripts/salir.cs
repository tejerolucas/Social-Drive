using UnityEngine;
using System.Collections;

public class salir : MonoBehaviour {
	public CanvasGroup canvas;
	// Use this for initialization
	void cerrar () {
		Application.Quit();
	}
	public void managercanvas(float valor){
		canvas.alpha=valor;
	}
	// Update is called once per frame
	public void cerrarapp () {
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",1,"onupdatetarget",this.gameObject,"onupdate","managercanvas","oncompletetarget",this.gameObject,"oncomplete","cerrar"));

	}
}
