using UnityEngine;
using System.Collections;

public class autoinicio : MonoBehaviour {
	public BoxCollider col;
	public Material[] materiales;
	public MeshRenderer mrend;
	// Use this for initialization
	void Start () {
		int num=Random.Range(0,materiales.Length);
		Material[] mats = mrend.materials;
		mats[0] = materiales[num];
		mrend.materials = mats;
		Invoke("prender",3f);
	}

	void prender () {
		col.enabled=true;
	}

	void Update(){
		if (ManagerGame.jugando) {
			this.transform.position += ManagerGame.velocidad * Time.deltaTime * this.transform.right * -1;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.layer==9){
			Destroy(this.gameObject);
		}
	}
}
