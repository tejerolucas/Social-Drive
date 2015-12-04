using UnityEngine;
using System.Collections;

public class botonmenu : MonoBehaviour {
	public GameObject musica;

	void OnMouseDown () {
		if(this.gameObject.name=="Quitbtn"){
			Application.Quit();
		}else{
			musica.SendMessage("Jugar");
		}
	}
}
