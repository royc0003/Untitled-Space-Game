using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour {
    [SerializeField]
    private Transform gun;
    void FixedUpdate() {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Physics.Raycast(rayOrigin, out hitInfo)) {
            if(hitInfo.collider != null) {
                //Debug.Log(hitInfo);
                Vector3 direction = hitInfo.point - gun.position;
                gun.rotation = Quaternion.LookRotation(hitInfo.point, Vector3.up);
            }
        }
    }
}
