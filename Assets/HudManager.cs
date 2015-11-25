using UnityEngine;
using System.Collections;

public class HudManager : MonoBehaviour {
	public GameObject automesh;
	public GameObject auto;
	public int index;
	private bool moviendo;

	void Start(){
		moviendo=false;
	}

	void rotacion (float valor) {
		automesh.transform.eulerAngles=new Vector3(0,valor,0);
	}

	void volver(){
		iTween.ValueTo(this.gameObject,iTween.Hash("from",automesh.transform.eulerAngles.y,"to",90,"time",0.1f,"onupdatetarget",this.gameObject,"onupdate","rotacion"));
	}
	void mover(float valor){
		moviendo=true;
		auto.transform.position=new Vector3(0,10,valor);
	}

	void moverfin(){
		moviendo=false;
	}
	
	// Update is called once per frame
	public void boton (int direccion) {
		if(!moviendo){
			Debug.Log("BOTON");
			if(direccion==1){
				if(auto.transform.position.z<=10){
					iTween.ValueTo(this.gameObject,iTween.Hash("from",90,"to",105,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","rotacion","oncompletetarget",this.gameObject,"oncomplete","volver"));
					iTween.ValueTo(this.gameObject,iTween.Hash("from",auto.transform.position.z,"to",auto.transform.position.z+18,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","mover","oncompletetarget",this.gameObject,"oncomplete","moverfin"));	
				}
			}else{
				if(auto.transform.position.z>=10){
					iTween.ValueTo(this.gameObject,iTween.Hash("from",90,"to",75,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","rotacion","oncompletetarget",this.gameObject,"oncomplete","volver"));
					iTween.ValueTo(this.gameObject,iTween.Hash("from",auto.transform.position.z,"to",auto.transform.position.z-18,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","mover","oncompletetarget",this.gameObject,"oncomplete","moverfin"));
				}
			}
		}
	}
}
