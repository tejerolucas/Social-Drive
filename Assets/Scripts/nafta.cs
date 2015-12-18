using UnityEngine;
using System.Collections;

public class nafta : MonoBehaviour {
	public ManagerGame mangame;

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.layer == 8) {
			mangame.gas+=mangame.gasmaximo/10;
		}
	}
}
