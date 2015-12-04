using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	void Jugar (){
		iTween.AudioTo(gameObject,iTween.Hash("audiosource",gameObject.GetComponent<AudioSource>(),"volume",0,"time",5,"oncompletetarget",gameObject,"oncomplete","destruir"));
	}

	void destruir(){
		Application.LoadLevel("Ruta");
	}
}
