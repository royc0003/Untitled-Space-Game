using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
    Transform transform;
    private float maxY;
    private float curY;
    private bool rendering;
    private bool rendered;

    void Awake () {
        maxY = 2.3743f;
        curY = 0f;
        rendering = false;
        rendered = false;
    }
    // Start is called before the first frame update
    void Start() {
        transform = GetComponent<Transform>();
        transform.localScale = new Vector3(1.379121f, curY, 3.276804f);
    }

    // Update is called once per frame
    void Update()
    {   
        // Start Animation
        if (rendering) {
             if (curY < maxY) {
                transform.localScale += new Vector3(0f,0.01f,0f);
                curY += 0.01f;
            }else{
                rendering = false;
                rendered = true;
            }
        }
    }

    public void render() {
        this.rendering = true;
    }

    public bool getRendered() {
        return this.rendered;
    }

}
