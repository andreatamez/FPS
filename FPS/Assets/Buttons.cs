using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.Quit();
	}

	public void BtnInstrucciones(){
		Application.LoadLevel("Instrucciones");
	}

	public void BtnInicio(){
		Application.LoadLevel("MainScene");
	}

	public void BtnSalir(){
		Application.Quit();
	}
}
