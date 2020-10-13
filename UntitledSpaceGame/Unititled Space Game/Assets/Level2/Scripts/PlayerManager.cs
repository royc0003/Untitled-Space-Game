using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Text enemiesLeftText;
    public Image HealthBar;
    public Animator animator;


    public static float health;
    public static int enemiesLeft;


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        enemiesLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        enemiesLeftText.text = "Enemies killed: " + enemiesLeft;
        //healthText.text = "Health: " + health;
        HealthBar.fillAmount = health / 100;

        if(health <= 0)
        {
            animator.SetTrigger("Dead");
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        Debug.Log("wait is over");
        SceneManager.LoadScene("Obstacle Course");
    }

}
