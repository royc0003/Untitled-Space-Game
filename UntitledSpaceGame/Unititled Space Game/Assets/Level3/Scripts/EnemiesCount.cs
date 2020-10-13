using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesCount : MonoBehaviour
{

    public Text enemyCount;
    float totalEnemies;
    // Start is called before the first frame update
    void Start()
    {
        totalEnemies = 0;
    }

    public void updateEnemyCount(float left)
    {

        string guiBulletCount = left.ToString() + " / " + totalEnemies.ToString();
        enemyCount.GetComponent<Text>().text = guiBulletCount;

    }

    public void setEnemyCount(float total)
    {

        totalEnemies = total;
        string guiBulletCount = totalEnemies.ToString() + " / " + totalEnemies.ToString();
        enemyCount.GetComponent<Text>().text = guiBulletCount;


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
