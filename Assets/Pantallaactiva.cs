using UnityEngine;
using System.Collections;
using MaterialUI;

public class Pantallaactiva : MonoBehaviour {
	public EZAnim anim;
	// Use this for initialization
	void OnEnable () {
		Invoke("Animar",0.1f);
	}
	
	// Update is called once per frame
	void Animar () {
		
		anim.AnimateAll();
	}
}
