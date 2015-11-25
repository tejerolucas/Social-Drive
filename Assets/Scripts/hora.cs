using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hora : MonoBehaviour {
	public Text texto;

	void Start () {
		texto=this.gameObject.GetComponent<Text>();
	}
	
	void Update () {
		int horas=System.DateTime.Now.Hour;
		int minutos=System.DateTime.Now.Minute;
		if(minutos<10){
			texto.text=horas.ToString()+":0"+minutos.ToString();
		}else{
			texto.text=horas.ToString()+":"+minutos.ToString();
		}
	}
}
