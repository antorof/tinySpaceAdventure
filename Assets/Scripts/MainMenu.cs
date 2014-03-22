﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public static int s_width;
	public static int s_height;
	public Texture2D tittleImg;

	// Use this for initialization
	void Start () {
		s_width = Screen.width;
		s_height = Screen.height;
		print ("Lvl: "+PlayerPrefs.GetInt("nivelAlcanzado", -1));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
	
	void OnGUI () {
		int b_width = 200; // Button width
		int b_height = 50; // Button height
		
		GUI.DrawTexture (new Rect ((s_width-tittleImg.width)/2,(s_height)/5,tittleImg.width,tittleImg.height), 
		           tittleImg);

		if(GUI.Button(new Rect ((s_width-b_width)/2,(s_height)/5+tittleImg.height+10,b_width,b_height), "Level 1")){
			Application.LoadLevel("level1");
		}
		/*if(GUI.Button(new Rect ((s_width-b_width)/2,(s_height)/2+b_height+10,b_width,b_height), "Scene 2")){
			Debug.Log("Btn 2");
		}*/
	}
}
