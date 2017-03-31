using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// basic game score
	public int Score = 0;
	public int Killed = 0;
	
	void Start () {
		Score = 0;
		Killed = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// add score function
	public void AddScore(int score){
		Score += score;
		Killed +=1;
        if (Killed >= 5)
        {
            if (Application.loadedLevel == 5)
            {
                //Application.LoadLevel("transaction");
                StartCoroutine(countdown());
                //yield return new WaitForSeconds(4.0f);
                //GUI.DrawTexture(new Rect(Screen.width, Screen.height , winning.height), winning);
                Application.LoadLevel("mountain2");

            }
            if (Application.loadedLevel == 6)
            {
                //Application.LoadLevel("transaction");
                //yield return WaitForSeconds(5);
                //GUI.DrawTexture(new Rect(Screen.width, Screen.height, winning.height), winning);
                Application.LoadLevel("snow2");
            }
        }
    }
	
	void OnGUI(){
		//GUI.Label(new Rect(20,20,300,30),"Kills "+Score);
	}
	// game over fimction
	public void GameOver(){
		GameUI menu = (GameUI)GameObject.FindObjectOfType(typeof(GameUI));
		if(menu){
			menu.Mode = 1;	
		}
	}
    IEnumerator countdown()
    {
        Application.LoadLevel("transaction");
        yield return new WaitForSeconds(10.0f);
    }
}
