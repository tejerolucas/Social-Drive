using UnityEngine;
using System.Collections;

public class Arbol : MonoBehaviour {
	private float velocidad;
	// Use this for initialization
	void Start () {
		velocidad=Manager.velocidad;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position+=velocidad*Time.deltaTime*transform.right;
	}
}
