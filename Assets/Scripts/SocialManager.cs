using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class SocialManager : MonoBehaviour {
	private CanvasGroup canvas;
	public int cantidad;
	public int cantidadinterna;
	public GameObject prefab;
	public GameObject panel;
	public Sprite[] spriteestados;
	public List<GameObject> estados=new List<GameObject>();
	public Image barra;

	void Awake () {
		canvas=this.gameObject.GetComponent<CanvasGroup>();
		CrearEstados();
	}
	
	void Update () {
		if(ManagerCelular.jugando){
		if(canvas.alpha>0){
			if(cantidadinterna<=0){
				if(ManagerCelular.jugando){
					cantidadinterna=10;
					Debug.Log("GANASTE");
					Limpiarestados();
					GameObject.Find("Celular").GetComponent<ManagerCelular>().Gane();
				}
			}else{
				barra.fillAmount=ManagerCelular.tiempoamount;
			}
		}
		}else{
			if(estados.Count>0){
				Limpiarestados();
			}
		}
	}

	public void CrearEstados(){
		Debug.Log("crear");
		barra.fillAmount=1;
		cantidadinterna=0;
		for(int i=0;i<cantidad;i++){
			GameObject go=Instantiate(prefab)as GameObject;
			estadofacebook est=go.GetComponent<estadofacebook>();
			est.imagen=spriteestados[Random.Range(0,spriteestados.Length)];
			go.transform.SetParent(panel.transform);
			go.transform.localScale=new Vector3(1,1,1);
			est.manager=this;
			estados.Add(go);
		}
	}

	void Limpiarestados(){
		Debug.Log("limpiar");
		foreach(GameObject go in estados){
			if(go!=null){
				go.GetComponent<estadofacebook>().destruir();
			}
		}
		estados.Clear();
	}
}
