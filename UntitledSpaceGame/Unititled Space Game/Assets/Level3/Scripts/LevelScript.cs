using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelScript : MonoBehaviour
{
    public GridController gridController;
    private int[] gridSizes;
    private int stage;
    bool gamePaused;
    bool renderGrid;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject bullet;
    public Image fuelMeter;
    public float totalPoints;
    public float target;
    public int lives;
    public Image[] images;
    public bool tutorialStage;
    public bool tutorialStagePart2;
    public GameObject playerCanvas;

    // Start is called before the first frame update
    void Start() {
        gridSizes = new int[] {0, 4, 5, 6};
        stage = 1;
        totalPoints = 0;
        lives = 3;
        gamePaused = true;
        tutorialStage = true;
        tutorialStagePart2 = true;

        renderGrid = true;
        bullet.GetComponent<Bullet>().setBulletColor();
        fuelMeter.fillAmount = 0;
        target = 60;


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("GAME PAUSED"+ gamePaused);

        if (!gamePaused)
        {
            Cursor.visible = false;
            showLives();
            fillFuel();

            if (renderGrid)
            {
                gridController.setAndStartGrid(gridSizes[stage]);
                renderGrid = false;
            }
            else
            {
                if (lives <= 0)
                {
                    Debug.Log("Game Over, you lose!");
                    Invoke("loadGameOver", 0.5f);
                }
                else if (totalPoints >= target)
                {
                    Debug.Log("Game Over, you win!");
                    Invoke("loadEndGame", 0.5f);

                }
                else
                {
                    if (gridController.checkSolution() == 1)
                    {
                        gridController.destroyAll();
                        stage++;
                        gridController.setAndStartGrid(gridSizes[stage]);
                        bullet.GetComponent<Bullet>().setBulletColor();
                    }
                    else if (gridController.checkSolution() == 0)
                    {
                        lives--;
                        gridController.destroyAll();
                        gridController.setAndStartGrid(gridSizes[stage]);
                        bullet.GetComponent<Bullet>().setBulletColor();
                    }
                }
            }
        }
        else
        {
            // Tutorial 
            if (tutorialStage)
            {
                Debug.Log("IN TUTORIAL STAGE");
                showLives();
                fillFuel();
                Cursor.visible = true;
                
                    if (renderGrid)
                    {
                        continueDialogue("1");
                        gridController.setAndStartGrid(gridSizes[stage]);
                        renderGrid = false;
                    }
                



            }
        }

    }

    void OnPauseGame()
    {
        gamePaused = true;
    }

  

    void OnResumeGame()
    {
        gamePaused = false;
    }

    void loadGameOver () {
        SceneManager.LoadScene("GameOver");
    }

    void loadEndGame()
    {
        SceneManager.LoadScene("End");
    }


    /*
    void checkSolution(){  //check the points if it reach the target


        if(totalPoints < target) {
            totalPoints += gridController.getGridPoints();

            if (gridController.checkGridStatus())
            {
                
                gridSize += 1;
                generateGrid();
                reloadBullet();
                
            }
            else
            {

                if (lives == 0)
                {
                    Debug.Log("GAME OVER");
                    //SHOW GAME OVER SCREEN
                    return;
                }
                else
                {
                    lives--;
                    generateGrid();
                }
                showLives();

            }

        }




    //go to next level
    }*/

    public void fillFuel() {  //affect the fuel meter
        float points = totalPoints / target;
        fuelMeter.fillAmount = points;
    }

    /*
    public void setLives(){  //test function to see lives
        lives--;
        showLives();
    }*/

    public void continueDialogue(string index)
    {
        Animator canvasAnimator = playerCanvas.GetComponent<Animator>();

        if (index != "6")
        {
            canvasAnimator.SetTrigger($"continue{index}");


        }
        else
        {
            Debug.Log("INSIDE CONTINUE 6");
            canvasAnimator.SetTrigger("continue6");
       
            tutorialStage = false;
            tutorialStagePart2 = false;
            gamePaused = false;


        }



    }

    void showLives()
    {

        switch (lives)
        {
            case 0:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);

                break;

            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);

                break;
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);

                break;

        }
    }


}