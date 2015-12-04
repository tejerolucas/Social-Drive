using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class MobileManager2 : MonoBehaviour {
	public CanvasGroup canvas;
	public RectTransform recttrans;
	public float inicialpos;
	private bool estado;
	private bool pausabool;
	public float tiempofade;
	public Camera cam;

	void Start () {
		tiempofade = 0.2f;
		pausabool=false;
		estado=false;
		inicialpos=recttrans.anchoredPosition.x;
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
		recttrans.anchoredPosition=new Vector2(valor,0);
	}

	void camview(float valor){
		Rect cast = new Rect (cam.rect.x, cam.rect.y, cam.rect.width, cam.rect.height);
		cast.x=valor;
		cam.rect = cast;
	}

	void canvasalpha(float valor){
		canvas.alpha=valor;
	}

	public void Pausa(){
		pausabool=true;
	}

	void Sacar(){

		//CAM
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",-0.3f,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","camview"));

		estado=true;
		iTween.ValueTo(this.gameObject,iTween.Hash("from",0,"to",1,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","canvasalpha"));
		iTween.ValueTo(this.gameObject,iTween.Hash("from",recttrans.anchoredPosition.x,"to",369,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","posi"));
	}

	void Bajar(){
		//CAM
		iTween.ValueTo(this.gameObject,iTween.Hash("from",-0.3f,"to",0,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","camview"));

		estado=false;
		iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","canvasalpha"));
		iTween.ValueTo(this.gameObject,iTween.Hash("from",369,"to",inicialpos,"time",tiempofade,"onupdatetarget",this.gameObject,"onupdate","posi"));
	}
}
