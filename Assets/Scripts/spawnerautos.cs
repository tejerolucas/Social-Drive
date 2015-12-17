using UnityEngine;
using System.Collections;

public class spawnerautos : MonoBehaviour {
	public GameObject auto;
	public Transform[] posiciones;
	public float intervalo;
	public float tiempo;

	void Start () {
		tiempo=Time.time;
	}
	
	void Update () {
		if(ManagerGame.jugando){
			if((Time.time-tiempo)>intervalo){
				tiempo=Time.time;
				Instantiate(auto,posiciones[Random.Range(0,posiciones.Length)].position,this.transform.rotation);
			}
		}
	}
}
