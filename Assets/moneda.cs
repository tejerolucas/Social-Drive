using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {
	public int valor;

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.layer == 8) {
			ManagerGame.monedas+=valor;
		}
	}
}
