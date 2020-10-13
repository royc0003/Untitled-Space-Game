using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    Transform transform;

    //public Alien alien;
    // correct or wrong
    public bool status;
    // clicked or unclicked
    public bool clicked;
    public Wall wall;
    public int row;
    public int col;

    public int height;
    public int width;
    public float gridHeight;
    public float gridWidth;
    public float intervalX;
    public float intervalY;
    public float startX;
    public GameObject incorrect;
    public float maxY;
    public float curY;
    public int timeStart;
    public int timeEnd;
    public bool rendered;
    public string type;
    public bool last;

    public GameObject myObj;
    public GameObject levelScript;
    public GameObject gridController;
    public GameObject bullet;
    public EnemiesCount enemiesCount; /// <summary>
                                      ///
                                      /// </summary>

    private Animator boxAnimator;
    private AudioSource score;
    private AudioSource deflect;

    private bool firstCorrectClick;

    void Awake()
    {
        // correct or wrong
        status = false;
        // clicked or unclicked
        clicked = false;

        timeStart = 0;
        timeEnd = 1000;
        rendered = false;

        AudioSource[] sound = GetComponents<AudioSource>();
        score = sound[1];
        deflect = sound[0];
        last = false;

        firstCorrectClick = false;


    }

    // Start is called before the first frame update
    void Start()
    {
        intervalX = gridWidth / width;
        intervalY = gridHeight / height;
        maxY = row * intervalY;
        //createAlien();
        transform = GetComponent<Transform>();
        //wall = GameObject.transform.GetChild(2).transform.GetComponent<Wall>();
        wall = myObj.GetComponentInChildren<Wall>();

        transform.localPosition = new Vector3(startX + col * intervalX, curY, 20f);

    }

    // Update is called once per frame
    void Update()
    {
        // Start animaton
        GridController gc = gridController.GetComponent<GridController>();
        LevelScript levelScriptComponent = levelScript.GetComponentInChildren<LevelScript>();

        if (curY < maxY)
        {
            transform.localPosition += new Vector3(0f, 0.05f, 0f);
            curY += 0.05f;
        }
        else
        {
            if (!levelScriptComponent.tutorialStagePart2)
            {

                if (!rendered)
                {
                    if (gc.curTime < gc.endTime)
                    {
                        wall.render();
                    }
                    rendered = wall.getRendered();
                }
                if (last)
                {
                    gc.curTime -= 1 * Time.deltaTime;
                }
            }
        }


    }

    public bool getBoxStatus()
    {
        return this.status;
    }

    public bool isBoxClicked()
    {
        return this.clicked;
    }

    public void setBoxStatus(bool status)
    {
        this.status = status;
    }

    public void setBoxClicked(bool clicked)
    {
        this.clicked = clicked;
    }

    public void randomizeAlien()
    {
        //this.alien.randomizeType();
    }

    void OnMouseDown()
    {
        LevelScript levelScriptComponent = levelScript.GetComponentInChildren<LevelScript>();
        Bullet bulletScript = bullet.GetComponentInChildren<Bullet>();
        GridController gridControllerComponent = gridController.GetComponentInChildren<GridController>();

        if (rendered)
        {
            if (string.Equals(bulletScript.curBulletColor, type))
            {   
                if (!firstCorrectClick) {
                    levelScriptComponent.totalPoints += 2;
                    gridControllerComponent.numberOfAliensLeft--;
                    enemiesCount.updateEnemyCount(gridControllerComponent.numberOfAliensLeft);
                    score.Play();
                    firstCorrectClick = true;
                    animateDestroy();

                }
            }
            else
            {
                //levelScriptComponent.lives--;
                gridControllerComponent.correct = false;
                incorrect.SetActive(true);
                deflect.Play();
            }
            Debug.Log("Lives: " + levelScriptComponent.lives + " Score: " + levelScriptComponent.totalPoints);
        }
    }

    public void animateDestroy()
    {
        boxAnimator = myObj.GetComponent<Animator>();
        boxAnimator.Play("DestroyBox");
        Destroy(gameObject, boxAnimator.GetCurrentAnimatorStateInfo(0).length - 0.3f);
    }

}
