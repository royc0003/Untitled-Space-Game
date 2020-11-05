using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject instr1;
    public GameObject instr2;
    public GameObject instr3;
    public GameObject instr4;
    public GameObject instr5;
    public GameObject instr6;
    public GameObject instr7;
    public Button nextBtn;
    public Button backBtn;
    public Button playBtn;
    private int instrId;
    
    // Start is called before the first frame update
    void Start()
    {
        nextBtn.gameObject.SetActive(true);
        instr1.SetActive(true);
        instr2.SetActive(false);
        instr3.SetActive(false);
        instr4.SetActive(false);
        instr5.SetActive(false);
        instr6.SetActive(false);
        instr7.SetActive(false);
        playBtn.gameObject.SetActive(false);
        backBtn.gameObject.SetActive(false);
        instrId = 1;
    }

    public void DisplayNextInstruction()
    {
        switch(instrId) {
            case 1:
                instr1.SetActive(false);
                instr2.SetActive(true);
                backBtn.gameObject.SetActive(true);
                instrId++;
                break;
            case 2:
                instr2.SetActive(false);
                instr3.SetActive(true);
                instrId++;
                break;
            case 3:
                instr3.SetActive(false);
                instr4.SetActive(true);
                instrId++;
                break;
            case 4:
                instr4.SetActive(false);
                instr5.SetActive(true);
                instrId++;
                break;
            case 5:
                instr5.SetActive(false);
                instr6.SetActive(true);
                instrId++;
                break;
            case 6:
                instr6.SetActive(false);
                instr7.SetActive(true);
                nextBtn.gameObject.SetActive(false);
                playBtn.gameObject.SetActive(true);
                instrId++;
                break;
            case 7:
                SceneManager.LoadScene("Level4");
                break;
            
        }
    }

    public void DisplayPreviousInstruction()
    {
        switch(instrId) {
            case 2:
                instr1.SetActive(true);
                instr2.SetActive(false);
                backBtn.gameObject.SetActive(false);
                instrId--;
                break;
            case 3:
                instr2.SetActive(true);
                instr3.SetActive(false);
                instrId--;
                break;
            case 4:
                instr3.SetActive(true);
                instr4.SetActive(false);
                instrId--;
                break;
            case 5:
                instr4.SetActive(true);
                instr5.SetActive(false);
                instrId--;
                break;
            case 6:
                instr5.SetActive(true);
                instr6.SetActive(false);
                instrId--;
                break;
            case 7:
                instr6.SetActive(true);
                instr7.SetActive(false);
                nextBtn.gameObject.SetActive(true);
                playBtn.gameObject.SetActive(false);
                instrId--;
                break;
            
        }
    }
}
