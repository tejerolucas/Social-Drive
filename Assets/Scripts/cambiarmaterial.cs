using UnityEngine;
using System.Collections;

public class cambiarmaterial : MonoBehaviour {
	public Material mat;
	public Color col;

	public void cambiar () {
		mat.color=col;
	}
}
