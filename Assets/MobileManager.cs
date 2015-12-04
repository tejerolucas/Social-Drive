using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MobileManager : MonoBehaviour {
	public CanvasGroup canvas;
	public RectTransform recttrans;
	public float inicialpos;
	private bool estado;
	private bool pausabool;

	void Start () {
		pausabool=false;
		estado=false;
		inicialpos=recttrans.anchoredPosition.y;
	}

	void Update(){
		if(!pausabool){
		    if(Input.GetKeyDown(KeyCode.Menu)){
			    if(!estado){
			    	Sacar();
			    }
		    }
		    if(Input.GetKeyDown(KeyCode.A)){
			    if(!estado){
			    	Sacar();
			    }
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			if(estado){
				Bajar();
			}
		}
		if(Input.GetKeyDown(KeyCode.S)){
			if(estado){
				Bajar();
			}
		}
		}
	}

	void posi(float valor){
		recttrans.anchoredPosition=new Vector2(0,valor);
	}
	void canvasalpha(float valor){
		canvas.alpha=valor;
	}

	public void Pausa(){
		pausabool=true;
	}

	void Sacar(){
		estado=true;
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",1,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","canvasalpha"));
		iTween.ValueTo(this.gameObject,iTween.Hash("from",recttrans.anchoredPosition.y,"to",0,"time",0.5f,"onupdatetarget",this.gameObject,"onupdate","posi"));
	}

	void Bajar(){
		estado=false;
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","canvasalpha"));
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",inicialpos,"time",0.5f,"onupdatetarget",this.gameObject,"onupdate","posi"));
	}
}
