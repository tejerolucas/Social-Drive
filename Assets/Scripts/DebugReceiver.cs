using UnityEngine;
using System.Collections;

public class DebugReceiver : MonoBehaviour {
	void Awake(){
		Network.InitializeServer(3,25001,false);
	}

	[RPC]
	void Debugger(string texto){
		Debug.Log(texto);
	}
}
