using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ShowHint : MonoBehaviour
{
    public Text uiObject;
    public Text uiObject2;

    public string HintText;
    public int HintNo = 3;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.enabled = false;
        uiObject2.enabled = false;

    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            uiObject.enabled = true;
            uiObject2.enabled = true;

            if (HintNo == 1) {
                StartCoroutine(Wait());
            }
            else
            {
                StartCoroutine(Wait2());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
        Destroy(uiObject2);
    }


    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(12);
        Destroy(uiObject);
        uiObject2.enabled = false;
    }

    void Update()
    {
        if (HintNo == 6)
        {
            if (Input.GetMouseButtonDown(0)) {
                uiObject2.enabled = true;
                StartCoroutine(Wait2());
            }
        }
    }
}
