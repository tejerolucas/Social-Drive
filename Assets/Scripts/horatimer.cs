using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class horatimer : MonoBehaviour {
	public Image horaclock;
	public Image minutosclock;
	public Image segundosclock;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int hora=System.DateTime.Now.Hour;
		int minutos=System.DateTime.Now.Minute;
		int segundos=System.DateTime.Now.Second;

		horaclock.fillAmount=(hora*1.0f)/24f;
		minutosclock.fillAmount=(minutos*1.0f)/60f;
			segundosclock.fillAmount=(segundos*1.0f)/60f;
	}
}
