using UnityEngine;
using System.Collections;

public class cambiarcolor : MonoBehaviour
{
	public Material mat;
	public Color[] colores;
	public float tweenDuration = 3;

	
	public void cambio(int col){
		Hashtable tweenParams = new Hashtable();
		tweenParams.Add("from", mat.color);
		tweenParams.Add("to", colores[col]);
		tweenParams.Add("time", tweenDuration);
		tweenParams.Add("easetype", iTween.EaseType.easeInOutQuint);
		tweenParams.Add("onupdate", "OnColorUpdated");
		
		iTween.ValueTo(this.gameObject, tweenParams);
	}

	private void OnColorUpdated(Color color)
	{
		mat.color = color;
	}
}