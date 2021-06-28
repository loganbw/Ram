using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
 
  [SerializeField] private Camera playerCam;

    // Update is called once per frame
    void Update()
    {
        Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;
        if(groundPlane.Raycast(ray, out rayLength)){
            Vector3 pointToLook = ray.GetPoint(rayLength);
            Debug.DrawLine(ray.origin, pointToLook, Color.yellow);
        }
    
        
    }
}
