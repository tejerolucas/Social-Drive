using UnityEngine;
using System.Collections;

public class SpawnerCoins : MonoBehaviour {
	public GameObject[] prefabs;
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
				Instantiate(prefabs[Random.Range(0,prefabs.Length)],posiciones[Random.Range(0,posiciones.Length)].position,this.transform.rotation);
			}
		}
	}
}
