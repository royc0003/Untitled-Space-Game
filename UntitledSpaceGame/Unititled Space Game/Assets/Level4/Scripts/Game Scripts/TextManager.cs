using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Text bulletCount;
    private Text totalCount;
    private void Awake() {
        bulletCount = GameObject.Find("UI/Gun Reticle Canvas/Player UI/Ammo UI/Bullet Count").GetComponent<Text>();
        totalCount =  GameObject.Find("UI/Gun Reticle Canvas/Player UI/Ammo UI/Bullet Total").GetComponent<Text>();
        
    }
    void Start()
    {
        bulletCount = GameObject.Find("UI/Gun Reticle Canvas/Player UI/Ammo UI/Bullet Count").GetComponent<Text>();
        totalCount =  GameObject.Find("UI/Gun Reticle Canvas/Player UI/Ammo UI/Bullet Total").GetComponent<Text>();
    }


    // Update is called once per frame
   
   public void setBulletCount(int count){
       this.bulletCount.text = count.ToString();
   }

   public void setTotalCount(int count){
       this.totalCount.text = count.ToString();
   }
}
