using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManagerGold : MonoBehaviour {
	public Text goldtext;
	public int gold;

	void Start () {
		
	}
	
	public int GetBalance () {
		return gold;
	}
}
