using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Image timerfill;
	public GameObject[] redes;

	public void red (int redind) {
		foreach(GameObject go in redes){
			go.SetActive(false);
		}
		redes[redind].SetActive(true);
	}
	
	void Update () {
		timerfill.fillAmount=ManagerCelular.tiempoamount;
	}
}
