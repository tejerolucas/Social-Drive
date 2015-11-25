using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Crearruta : MonoBehaviour {
	public GameObject ruta;
	public int cantidad;
	public bool hacer=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(hacer){
			hacer=false;
			for(int i=1;i<cantidad+1;i++){
				Instantiate(ruta,this.transform.position+new Vector3(-80*i,0,0),this.transform.rotation);
			}
		}
	}
}
