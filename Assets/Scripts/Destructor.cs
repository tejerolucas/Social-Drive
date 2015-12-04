using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {
	void OnTriggerEnter (Collider c) {
		if(c.GetComponent<Collider>().gameObject.tag=="Destruir"){
			Destroy(c.GetComponent<Collider>().gameObject);
		}
	}
}
