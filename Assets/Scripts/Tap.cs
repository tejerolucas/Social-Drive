using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour {

	void Start(){
		iTween.ScaleTo(gameObject,iTween.Hash("name","elastico","scale",new Vector3(0.6f,0.6f,0.6f),"time",2,"looptype",iTween.LoopType.pingPong,"easetype",iTween.EaseType.easeInElastic));
	}

	void Jugar () {
		iTween.Stop(gameObject);
		iTween.FadeTo(gameObject, iTween.Hash("alpha",0,"time",1,"oncompletetarget",this.gameObject,"oncomplete","destruir"));
	}

	void destruir(){
		Destroy(this.gameObject);
	}
}
