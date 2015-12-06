using UnityEngine;
using System.Collections;

public class valor : MonoBehaviour {
	public int precio;
	public GameObject ads;
	public GameObject money;

	void Awake () {
		if(precio<0){
			money.SetActive(false);
			ads.SetActive(true);
		}else{
			if(precio==0){
				this.gameObject.SetActive(false);
			}else{
				money.SetActive(true);
				ads.SetActive(false);
			}
		}
	}
}
