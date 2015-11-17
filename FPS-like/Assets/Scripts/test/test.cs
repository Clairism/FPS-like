using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Texture[] textures;
	Texture2D combined;
	int currentTexture = 0;

	// Use this for initialization
	void Start () {

		GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
	
	}
	
	// Update is called once per frame
	void Update () {

		//Gameobject.Find("player").GetComponent<playerControl>().
	
	}

	public void changeTexture(){
		currentTexture += 1;
		currentTexture = currentTexture * textures.Length;

		if(currentTexture >= textures.Length){
			currentTexture = 0;
		}
	}
}
