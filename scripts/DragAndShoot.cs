using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndShoot : MonoBehaviour
{
    //
    //Right now just trying to play around with direction and movement of the cube 
    //
     //Currently have it set for PC for testing and will move it to phone once the logic is there
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Rigidbody rb;
    public Transform ram;
    public float speed;
    public float ramAngle;
    bool startMove = true;

    public int power = 50;
    private void Start(){
    }

   private void Update() {
        ///This moves the cube depending on where your mouse is
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;
    
        // END MMOVEMENT
        
            if(Physics.Raycast(ray, out RaycastHit raycastHit ))
            {
              print(raycastHit.point);

               if (Input.GetMouseButtonUp(0))
       
                {
                   
                    rb.AddForce(  2 * transform.position - raycastHit.point * power);
        
                }
      

        if( Input.GetMouseButton(0))
        {
               if(groundPlane.Raycast(ray, out rayLength)){
                Vector3 pointToLook = ray.GetPoint(rayLength);
                Debug.DrawLine(ray.origin, pointToLook, Color.yellow);
                transform.LookAt(2 * transform.position - pointToLook);
                }
        }  
       }
   }
//    void rotateRam(){
//         Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
//         Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
//         float rayLength;
//         if(groundPlane.Raycast(ray, out rayLength)){
//             Vector3 pointToLook = ray.GetPoint(rayLength);
//             Debug.DrawLine(ray.origin, pointToLook, Color.yellow);
//         }
    
//    }
 }
