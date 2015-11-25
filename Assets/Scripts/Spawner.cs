using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject objeto;
	public float intervalo;
	public float tiempo;
	public float ancho;

	void Start () {
		tiempo=Time.time;
	}
	

	void Update () {
//		if(Manager.jugando){
//			if((Time.time-tiempo)>intervalo){
//				tiempo=Time.time;
//				Instantiate(objeto,new Vector3(transform.position.x,transform.position.y,Random.Range(transform.position.z-ancho,transform.position.z+ancho)),this.transform.rotation);
//			}
//		}
	}

	void OnDrawGizmos(){
		Gizmos.color=Color.red;
		Gizmos.DrawLine(this.transform.position-new Vector3(0,0,ancho),this.transform.position+new Vector3(0,0,ancho));
	}
}
