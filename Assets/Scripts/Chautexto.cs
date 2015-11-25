using UnityEngine;
using System.Collections;

public class Chautexto : MonoBehaviour {
	void Jugar () {
		iTween.FadeTo(gameObject, iTween.Hash("alpha",0,"time",3,"oncompletetarget",this.gameObject,"oncomplete","destruir"));
	}

	void destruir(){
		Destroy(this.gameObject);
	}
}
