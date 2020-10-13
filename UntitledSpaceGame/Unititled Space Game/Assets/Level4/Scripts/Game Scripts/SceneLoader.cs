using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    //Create a public method that reloads the game
    // Hook this up to Play Again Button
    // Create a public method that quits the game
    // Hook this up to the Quit button
    public void ReloadGame(){
        //hello
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1;

    }
  
  public void QuitGame(){
      Application.Quit();
  }
}
