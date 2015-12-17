using UnityEngine;
using System.Collections;

public class checkgass : MonoBehaviour {
	public ManagerGame mangame;
	void OnTriggerEnter (Collider c) {
		if (c.gameObject.layer == 8) {
			mangame.showgas();
		}
	}

	void OnTriggerExit (Collider c) {
		if (c.gameObject.layer == 8) {
			mangame.hidegas();
		}
	}
}
