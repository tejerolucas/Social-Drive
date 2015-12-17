using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class estadofacebook : MonoBehaviour {
	public SocialManager manager;
	public Sprite imagen;
	public Image contenido;
	public Color[] tipos;
	private int tipo;
	public LayoutElement lay;
	public CanvasGroup canvas;

	void Start () {
		contenido.sprite=imagen;
		tipo=Random.Range(0,tipos.Length);
		if(tipo!=3){
			manager.cantidadinterna++;
		}
		this.gameObject.GetComponent<Image>().color=tipos[tipo];

	}
	
	public void boton (int num) {
		if(num==tipo){
			ManagerGame.monedas++;
			manager.cantidadinterna-=1;
			float valor=imagen.rect.height;
			iTween.ValueTo(this.gameObject,iTween.Hash("from",valor,"to",0,"time",0.3f,"onupdatetarget",this.gameObject,"onupdate","achicar","oncompletetarget",this.gameObject,"oncomplete","destruir"));
			iTween.ValueTo(this.gameObject,iTween.Hash("from",1,"to",0,"time",0.2f,"onupdatetarget",this.gameObject,"onupdate","alpha"));
		}
	}

	void alpha(float valor){
		canvas.alpha=valor;
	}

	void achicar(float valor){
		lay.preferredHeight=valor;
	}

	public void destruir(){
		Destroy(this.gameObject);
	}
}
