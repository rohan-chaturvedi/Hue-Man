using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartGame : MonoBehaviour {


	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update ()
 //   {
        

 //   }

    public void NextLevelButton(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}
