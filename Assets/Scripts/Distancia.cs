using UnityEngine;
using System.Collections;

public class Distancia : MonoBehaviour {
	public float distancia;
	public GUIText gt;

	void Jugar(){
		float cola=0;
		iTween.ValueTo(gameObject,iTween.Hash("from",0.0f,"to",1.0f,"delay",1,"time",2,"onUpdate", "Colorchange"));
	}

	void Colorchange(float val){
		Color cl=gt.color;

		gt.color=new Color(cl.r,cl.g,cl.b,val);
	}

	void Update () {
//		if(Jugador.jugando){
//			distancia+=Jugador.velocidad/3600;
//			if(distancia<1000){
//				gt.text=((int)distancia).ToString()+" Mts";
//			}else{
//				gt.text=(distancia/1000).ToString("F2")+" Km";
//			}
//		}
	}
}
