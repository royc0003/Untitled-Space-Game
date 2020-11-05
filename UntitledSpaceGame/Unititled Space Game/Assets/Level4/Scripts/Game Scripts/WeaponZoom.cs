using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Assets/Level 4/Others/Low Poly FPS Pack - Free (Sample)/Components/Scripts/FPSController/FpsControllerLPFP.cs
using FPSControllerLPFP;

public class WeaponZoom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 79f;
    [SerializeField] float zoomedInFOV = 39f;
    [SerializeField] float zoomOutSensitivity = 7f;
    [SerializeField] float zoomInSensitivity = 1f;


    bool zoomedInToggle = false;
    public AudioSource zoomSound;
    public AudioClip zoomClip;
    private AudioManager2 ADM;

    private int counter = 0;

    FpsControllerLPFP fpsController;


    // Update is called once per frame
    void Start(){
        // change to aiming sound
        ADM = GetComponent<AudioManager2>();
        fpsController = GetComponent<FpsControllerLPFP>();
        this.zoomClip = ADM.changeBGM(4);
        
    }
    private void OnDisable() {
        ZoomOut();
        
    }
    void Update()
    {

        if(Input.GetMouseButtonDown(1)){
            if(zoomedInToggle == false)
            {
                AudioSource.PlayClipAtPoint(zoomClip, transform.position, 0.7f);
            }
            else
            {
                AudioSource.PlayClipAtPoint(zoomClip, transform.position, 0.7f);

            }
        }

        if(Input.GetMouseButton(1)){
            ZoomIn();
        }
        else{
            ZoomOut();
        }

    }

    private void ZoomOut()
    {
        fpsController.setMouseSensitivity(zoomOutSensitivity);
        zoomedInToggle = false;
        fpsCamera.fieldOfView = this.zoomedOutFOV;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = this.zoomedInFOV;
        fpsController.setMouseSensitivity(zoomInSensitivity);
    }



}
