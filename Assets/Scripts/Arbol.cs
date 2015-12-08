using UnityEngine;
using System.Collections;

public class Arbol : MonoBehaviour {
	private float velocidad;

	void Update () {
		velocidad=ManagerGame.velocidad;
		this.transform.position+=velocidad*Time.deltaTime*transform.right;
	}
}
