using UnityEngine;
using System.Collections;

public class autoinicio : MonoBehaviour {
	public BoxCollider col;
	// Use this for initialization
	void Start () {
		Invoke("prender",3f);
	}
	
	// Update is called once per frame
	void prender () {
		col.enabled=true;
	}
}
