using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class cambiarvolumen : MonoBehaviour {
	public AudioMixer group;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void FXvolumen (float valor) {
		group.SetFloat("FXvol",valor);
	}

	public void Musicvolumen (float valor) {
		group.SetFloat("Musicvol",valor);
	}
}
