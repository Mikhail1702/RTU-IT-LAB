using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
 public Camera FrontCamera;
 public Camera LeftCamera;

 public Camera RightCamera;
 
 public Camera BackCamera;
    // Start is called before the first frame update

 void Start(){
    FrontCamera.enabled = true;
    BackCamera.enabled = false;
    LeftCamera.enabled = false;
    RightCamera.enabled = false;
             
 }
 void Update(){
       
       if (transform.position.z <= 0 && transform.position.x < 4.380 && Input.GetAxisRaw("LeftandRight")<0)
     {
        Debug.Log("Front Left");
       
             transform.rotation=Quaternion.Euler(0, -90, 0); 
             //cделать движение
             transform.position = new Vector3((float)4.125, transform.position.y, (float)0.05);
             gameObject.GetComponent<AssassinControl>().wheremoving =  2;
             Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
             FrontCamera.enabled = false;
             BackCamera.enabled = false;
             LeftCamera.enabled = false;
             LeftCamera.enabled = true;
             
             //изменить фиксированное rigit body
            
    }
    if (transform.position.z >= 7.523702  && transform.position.x <= 4.3 && Input.GetAxisRaw("LeftandRight")<0)
         {
        Debug.Log("Left Back");
       
             transform.rotation=Quaternion.Euler(0, -180, 0); 
             //cделать движение
             transform.position = new Vector3((float)4.366,transform.position.y, (float)7.90);
              gameObject.GetComponent<AssassinControl>().wheremoving =  4;
              Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
            FrontCamera.enabled = false;
             RightCamera.enabled = false;
             LeftCamera.enabled = false;
             BackCamera.enabled = true;
    }
    if (transform.position.z >= 7.75  && transform.position.x >= 11.72)
         {
        Debug.Log("Back Right");
       
             transform.rotation=Quaternion.Euler(0, -90, 0); 
             //cделать движение
             transform.position = new Vector3((float)11.987, transform.position.y, (float)7.97);
              gameObject.GetComponent<AssassinControl>().wheremoving =  3;
              Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
            FrontCamera.enabled = false;
             BackCamera.enabled = false;
             LeftCamera.enabled = false;
             RightCamera.enabled = true;
    }
      if (transform.position.z <= -0.3 && transform.position.x > 11.0)
         {
        Debug.Log("Right Front");
       
             transform.rotation=Quaternion.Euler(0, -180, 0); 
             //cделать движение
             transform.position = new Vector3((float)11.776, transform.position.y, (float)-0.64);
              gameObject.GetComponent<AssassinControl>().wheremoving =  1;
              Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
            FrontCamera.enabled = true;
             BackCamera.enabled = false;
             LeftCamera.enabled = false;
             RightCamera.enabled = false;
         }
       if (transform.position.z <= 0.050 && transform.position.x < 4.380 && Input.GetAxisRaw("LeftandRight")>0) // gets left)
     {
        Debug.Log(" Left Front");
       
             transform.rotation=Quaternion.Euler(0, 0, 0); 
             //cделать движение
             transform.position = new Vector3((float)4.380, transform.position.y, (float)-0.64);
             gameObject.GetComponent<AssassinControl>().wheremoving =  1;
             Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
             FrontCamera.enabled = true;
             BackCamera.enabled = false;
             LeftCamera.enabled = false;
             LeftCamera.enabled = false;
             
             //изменить фиксированное rigit body
            
    }
    if (transform.position.z >= 7.523702  && transform.position.x <= 4.3666 && Input.GetAxisRaw("LeftandRight")>0)
         {
        Debug.Log("Back Left");
       
             transform.rotation=Quaternion.Euler(0, -90, 0); 
             //cделать движение
             transform.position = new Vector3((float)4.125, transform.position.y, (float)7.523702);
              gameObject.GetComponent<AssassinControl>().wheremoving =  2;
              Debug.Log(gameObject.GetComponent<AssassinControl>().wheremoving);
            FrontCamera.enabled = false;
             RightCamera.enabled = false;
             LeftCamera.enabled = true;
             BackCamera.enabled = false;
    }

    }}

    