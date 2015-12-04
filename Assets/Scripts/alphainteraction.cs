using UnityEngine;
using System.Collections;

public class alphainteraction : MonoBehaviour {
	private CanvasGroup canvas;
	// Use this for initialization
	void Start () {
		canvas=this.gameObject.GetComponent<CanvasGroup>();
	}
	
	// Update is called once per frame
	void Update () {
		if(canvas.alpha<=0){
			canvas.blocksRaycasts=false;
			canvas.interactable=false;
		}else{
			canvas.blocksRaycasts=true;
			canvas.interactable=true;
		}
	}
}
