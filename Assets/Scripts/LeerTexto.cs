using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Globalization;

public class Men:MonoBehaviour{
	public int index;
	public string owner;
	public string msj;
}

public class LeerTexto : MonoBehaviour {
	public Texture whatsapp;
	public string[] mensajes;
	public List<Men> mensajeslimpios = new List<Men> ();
	public Vector2 posicion;
	public Texture mia;
	public Texture maxi;
	// Use this for initialization
	void Start () {
		mensajes =File.ReadAllLines(@"D:\Documents\xmltest\Assets\Chat.txt");
//		for(int i=0;i<mensajes.Length;i++){
//			string s=mensajes[i];
//			int f = s.IndexOf('-');
//			string d = s.Substring(f+2);
//			string[] split=d.Split(':');
//			Men m=new Men();
//			m.index=i;
//			m.owner=split[0];
//			m.msj=split[1];
//
//			mensajeslimpios.Add(m);
//		}
		//WriteToXml();
	}

	public void WriteToXml (){
		string filepath = @"D:\Documents\xmltest\Assets\SaveData.xml";
		XmlDocument xmlDoc = new XmlDocument ();
		if (File.Exists (filepath)) {
			xmlDoc.Load (filepath);
			
			XmlElement elmRoot = xmlDoc.DocumentElement;
			
			elmRoot.RemoveAll (); // clear all inside the transforms node.
			
			XmlElement elmNew = xmlDoc.CreateElement ("Chat"); // create the rotation node.
			for(int i=0;i<mensajeslimpios.Count;i++){
				XmlElement Mensaje = xmlDoc.CreateElement ("Mensaje"); // create the y node.
				Mensaje.SetAttribute("index",mensajeslimpios[i].index.ToString());
				Mensaje.SetAttribute("owner",mensajeslimpios[i].owner);
				Mensaje.SetAttribute("msj",mensajeslimpios[i].msj);
			
				elmNew.AppendChild (Mensaje);
				elmRoot.AppendChild (elmNew); // make the transform node the parent.
			}
			xmlDoc.Save (filepath); // save file.
		}
	}

	void OnGUI () {
		GUI.color = Color.white;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), whatsapp);
	}
}
