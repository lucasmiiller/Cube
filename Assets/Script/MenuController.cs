﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController: MonoBehaviour {
	private GameObject Play;
	private GameObject opcoes;
	private GameObject creditos;
	private GameObject instrucoes;
	private GameObject Voltar;
	// Use this for initialization
	void Start () {
		if(Application.loadedLevel.Equals(3))Play = GameObject.Find("Tplay");
		if(Application.loadedLevel.Equals(3))opcoes = GameObject.Find("Top");
		if(Application.loadedLevel.Equals(3))creditos = GameObject.Find("Tcred");
		if(Application.loadedLevel.Equals(3))instrucoes = GameObject.Find("Tinstr");
		if(Application.loadedLevel != 3 && Application.loadedLevel != 1 )Voltar = GameObject.Find("voltar");
	}
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel.Equals(3)){
			if (!Play.activeSelf)Application.LoadLevel("Game");
			else if(!opcoes.activeSelf)Application.LoadLevel("opcoes");
			else if(!creditos.activeSelf)Application.LoadLevel("creditos");
			else if(!instrucoes.activeSelf)Application.LoadLevel("instrucoes");
		}
		if(Application.loadedLevel != 3 && Application.loadedLevel != 1 && !Voltar.activeSelf)Application.LoadLevel("Menu");
	}
}
