using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject theNPC;
    
    void Start(){
    }


    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetButtonDown("Hit"))
        {
            theNPC.GetComponent<Animator>().Play("Baseball Strike (3)");
            
            
        }
         
    }
}

