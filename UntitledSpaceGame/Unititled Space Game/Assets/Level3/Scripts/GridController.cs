using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GridController : MonoBehaviour {
    private BoxController[,] grid;
    private GameObject[,] gridObject;
    private int height;
    private int width;
    private int gridHeight;
    private int gridWidth;
    public GameObject boxPrefab;
    public GameObject box2Prefab;
    private float startX;
    private float maxY;
    private float curY;
    string[] types;
    int[] typesArr;
    System.Random r;
    public EnemiesCount enemiesCount;

    public float numberOfAliensLeft;
    public bool correct;

    public float curTime;
    public float endTime;
    public Text countDown;

    void Awake() {       
        gridHeight = 10;
        gridWidth = 40;
        startX = -16;
        curY = -3.6f;
        height = 4;
        curTime = 10f;
        endTime = 0f;
        
        //setAndStartGrid(4);
    }

    public void setAndStartGrid(int width) {
        this.width = width;
        numberOfAliensLeft = (width*height)/2;   //total number of bullets
        enemiesCount.setEnemyCount(numberOfAliensLeft);
        correct = true;
        grid = new BoxController[height, width];
        gridObject = new GameObject[height, width];
        types = new string[] {"G", "R"};
        r = new System.Random();

        typesArr = new int[height*width];
        for (int j = 0; j < height*width; j++) {
            if (j < (height*width)/2){
                typesArr[j] = 0;
            }else{
                typesArr[j] = 1;
            }
        }
        typesArr = typesArr.OrderBy(x => r.Next()).ToArray();
        int index = 0;
        for (int row = 0; row < height; row++) {
            for (int col = 0; col < width; col++) {
                string type = types[typesArr[index]];
                index++;
                // Render prefab according to type
                GameObject a = null;
                if (type=="G"){
                    a = Instantiate(boxPrefab);
                }else if(type == "R"){
                    a = Instantiate(box2Prefab);
                }else{
                    a = Instantiate(boxPrefab);
                }
                gridObject[row, col] = a;
                grid[row, col] = a.GetComponent<BoxController>();
                grid[row, col].row = row;
                grid[row, col].col = col;
                grid[row, col].width = width;
                grid[row, col].height = height;
                grid[row, col].gridHeight = gridHeight;
                grid[row, col].gridWidth = gridWidth;
                grid[row, col].startX = startX;
                grid[row, col].curY =  curY;
                grid[row, col].myObj = a;
                grid[row, col].type = type;
            }
        }
        grid[height-1, width-1].last = true;
        curTime = 10f;
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (curTime > endTime) {
            countDown.text = curTime.ToString("0");
        }
    }



    public BoxController[,] getGrid() {
        return grid;
    }

    public int checkSolution() {
        if (numberOfAliensLeft <= 0) {
            if (correct) {
                return 1;
            }else {
                return 0;
            }
        }
        return -1;
    }

    public void destroyAll() {
        for (int row = 0; row < height; row++) {
            for (int col = 0; col < width; col++) {
                Destroy(gridObject[row, col]);
            }
        }
        gridObject = null;
        grid = null;
    }

    public int getGridPoints() {
        return 0;  //0 first or the fuel meter will increase every update 
    }
}
    