using UnityEngine;
using System.Collections;

public class girarui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<RectTransform>().eulerAngles-=new Vector3(0,0,3);
	}
}
