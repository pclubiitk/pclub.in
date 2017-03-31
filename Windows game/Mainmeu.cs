using UnityEngine;
using System.Collections;

public class Mainmeu : MonoBehaviour {

	public GUISkin skin;
	public Texture2D Logo;
    public GameObject loadingimage;

	void Start () {
	
	}
	
	void Update () {
	
	}
	
	public void OnGUI(){
		if(skin)
		GUI.skin = skin;
		
		GUI.DrawTexture(new Rect(Screen.width/2 - Logo.width/2 , Screen.height/2 - 150,Logo.width,Logo.height),Logo);
		
		if(GUI.Button(new Rect(Screen.width/2 - 300,Screen.height/2 + 50,300,40),"Ease with Desert")){
			Application.LoadLevel("main");
		}
		if(GUI.Button(new Rect(Screen.width/2 + 100,Screen.height/2 + 50,300,40),"Medium in Mountain")){
			Application.LoadLevel("mountain");
		}
        if (GUI.Button(new Rect(Screen.width/2 - 300,Screen.height/2 + 100,300,40),"Hard in snow")){
            Application.LoadLevel("snow");
		}
        if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 + 100, 300, 40), "Control"))
        {
            Application.LoadLevel("configuration");
        }
        if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2 +150,300,40),"Story Line"))
        {
            Application.LoadLevel("starter");
            Application.LoadLevel("main2");
        }
        }
    
}
