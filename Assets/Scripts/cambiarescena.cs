using UnityEngine;
using System.Collections;

public class cambiarescena : MonoBehaviour {
	public Color col;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void ChangeScene (string escena) {
		AutoFade.LoadLevel(escena,1,1,col);
	}
}
