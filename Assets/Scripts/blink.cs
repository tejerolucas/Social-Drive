using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blink : MonoBehaviour {
	private Text texto;
	private bool state;

	void Start () {
		texto=this.gameObject.GetComponent<Text>();
		state=false;
		InvokeRepeating("change",1,1);
	}
	
	void change () {
		texto.enabled=state;
		state=!state;
	}
}
