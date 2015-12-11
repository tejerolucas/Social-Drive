using UnityEngine;
using System.Collections;

public class Arbol : MonoBehaviour {
	private float velocidad;

	void Update () {
		if (ManagerGame.jugando) {
			velocidad = ManagerGame.velocidad;
			this.transform.position += velocidad * Time.deltaTime * transform.right;
		}
	}
}
