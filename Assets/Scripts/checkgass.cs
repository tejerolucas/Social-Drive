using UnityEngine;
using System.Collections;

public class checkgass : MonoBehaviour {
	public ManagerGame mangame;
	public int valor;

	void Start(){
		mangame=GameObject.Find("Manager").GetComponent<ManagerGame>();
	}

	void OnTriggerEnter (Collider c) {
		Debug.Log("CHOCO");
		if (c.gameObject.layer == 8) {
			Debug.Log("CHOCO AUTO");
			mangame.showgas(valor);
		}
	}

	void OnTriggerExit (Collider c) {
		if (c.gameObject.layer == 8) {
			mangame.hidegas();
		}
	}
}
