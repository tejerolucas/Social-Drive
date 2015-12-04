using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mensaje : MonoBehaviour {
	public Image imagen;
	public Color[] colores;
	public Text texto;
	public string textomensaje;
	// Use this for initialization
	void Start () {
		int num=Random.Range(0,colores.Length);
		imagen.color=colores[num];
		texto.text=textomensaje;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
