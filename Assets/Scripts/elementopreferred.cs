using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementopreferred : MonoBehaviour {
	public LayoutElement lay; 
	public Image imagen;
	// Use this for initialization
	void Start () {
		lay=this.gameObject.GetComponent<LayoutElement>();
		imagen=this.gameObject.GetComponent<Image>();
		lay.preferredWidth=imagen.sprite.rect.width;
		lay.preferredHeight=imagen.sprite.rect.height;
	}

}
