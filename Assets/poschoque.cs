using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class poschoque : MonoBehaviour {
	public GameObject punta;
	public float distancia;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(punta.transform.position);
		if(Vector3.Distance(this.gameObject.transform.position,punta.transform.position)<distancia){
			this.transform.position-=0.01f*this.transform.forward;
		}
	}
}
