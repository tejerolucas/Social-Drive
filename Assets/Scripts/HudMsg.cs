using UnityEngine;
using System.Collections;

public class HudMsg : MonoBehaviour {
	public float timercurrent;
	public float timertotal;
	public GameObject circulo;
	public AudioClip msj;
	public AudioClip fail;
	public AudioClip reloj;

	void MensajeRecibido (float tiempo) {
		timercurrent=0;
		timertotal=tiempo;
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().Play();
		iTween.ScaleTo(gameObject,iTween.Hash("scale'",new Vector3(0.9f,0.9f,0.9f),"time",0.7f,"easetype",iTween.EaseType.easeOutElastic));
		iTween.ValueTo(gameObject,iTween.Hash("name","countdown","from",0,"to",tiempo,"time",tiempo,"onupdate","ajustartiempo"));
	}

	void ajustartiempo(float tim){
		timercurrent=tim;
		circulo.GetComponent<Renderer>().material.SetFloat("_Alpha",(timercurrent*1)/timertotal);
		if(!GetComponent<AudioSource>().isPlaying){
			if(((timertotal-timercurrent)<5)&&((timertotal-timercurrent)>4)){
				GetComponent<AudioSource>().Stop();
				GetComponent<AudioSource>().clip=reloj;
				GetComponent<AudioSource>().Play ();
			}
		}
		if(timercurrent==timertotal){
			GetComponent<AudioSource>().Stop();
			GetComponent<AudioSource>().clip=fail;
			GetComponent<AudioSource>().Play();
		}
	}

	void MensajeRespondido () {
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip=msj;
		iTween.StopByName("countdown");
		iTween.ScaleTo(gameObject,iTween.Hash("scale",new Vector3(0.001f,0.001f,0.001f),"time",0.2f));
	}
}
