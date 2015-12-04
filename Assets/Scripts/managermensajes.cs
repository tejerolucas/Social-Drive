using UnityEngine;
using System.Collections;

public class managermensajes : MonoBehaviour {
	public GameObject prefab;
	public GameObject panel;

	
	public void crearmensaje (string msjtxt) {
		GameObject mensaje=Instantiate(prefab,this.transform.position,this.transform.rotation) as GameObject;
		mensaje msj=mensaje.GetComponent<mensaje>();
		msj.textomensaje=msjtxt;
		mensaje.transform.parent=panel.transform;
		mensaje.transform.localScale=new Vector3(1,1,1);
	}

	public void value(string valor){
		Debug.Log(valor);
	}
}
