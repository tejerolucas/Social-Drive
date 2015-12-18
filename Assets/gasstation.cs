using UnityEngine;
using System.Collections;

public class gasstation : MonoBehaviour {
	public Material mat;
	public int[] valores;
	public Color[] colores;
	public checkgass[] checks;

	void Start () {
		int num=Random.Range(0,valores.Length);
		int valor=valores[num];
		mat.color=colores[num];
		foreach(checkgass ch in checks){
			ch.valor=valor;
		}

	}

}
