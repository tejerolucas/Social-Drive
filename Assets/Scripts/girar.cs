using UnityEngine;
using System.Collections;

public class girar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.eulerAngles+=new Vector3(0,1,0);
	}
}
