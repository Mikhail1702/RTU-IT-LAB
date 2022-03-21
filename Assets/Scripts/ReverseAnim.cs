using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ReverseAnim : MonoBehaviour {
 
	// Use this for initialization
   
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Animator anim = gameObject.GetComponent<Animator> ();
			// Reverse animation play
			anim.SetFloat ("Direction", -1);
			anim.Play ("Baseball Strike (3)");
            
            
            }

        }
		
        
	}
