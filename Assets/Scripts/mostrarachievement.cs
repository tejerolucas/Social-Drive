using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mostrarachievement : MonoBehaviour {
	public Text texto;
	public int tiempo;
	public Animator animator;

	public void Mostrar (string mensaje) {
		texto.text=mensaje;
		animator.SetTrigger("Open");
		Invoke("Cerrar",tiempo);
	}
	
	// Update is called once per frame
	void Cerrar () {
		animator.SetTrigger("Close");
	}
}
