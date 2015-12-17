using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class webcamui : MonoBehaviour {
	public RawImage imagen;
	
	void Awake () {
		WebCamTexture webcam=new WebCamTexture();
		imagen.texture = webcam;
		imagen.material.mainTexture=webcam;
		webcam.Play();
	}
}
