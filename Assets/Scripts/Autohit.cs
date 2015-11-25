using UnityEngine;
using System.Collections;

public class Autohit : MonoBehaviour {
	public float distancia;
	private float velocidad;
	private GameObject auto;
	private bool check=true;
	// Use this for initialization
	void Start () {
	//	velocidad=Jugador.velocidad;
		auto=GameObject.FindWithTag("Auto");
	}

	void Update () {
		this.transform.position+=velocidad*Time.deltaTime*this.transform.right*-1;
		if(check){
			if(Vector3.Distance(this.transform.position,auto.transform.position)<distancia){
				GetComponent<AudioSource>().Play();
				check=false;
			}
		}
	}
}
