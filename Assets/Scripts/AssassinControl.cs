using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AssassinControl : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    public float runSpeed = 40f;
      public bool isDead = false;
    float horizontalMove = 0f;
    public float speed = 10f;
    public Rigidbody rb;
    public bool cubeIsOnTheGround = true;
    public GameObject assassin;
    
    public Animator animator;

    public int wheremoving;
    //1 - front
    //2 -left
    //3 - right
    //4- back
    

   
    void Start()
    {
        wheremoving = 1;
        
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        horizontalMove = Input.GetAxisRaw("LeftandRight")*runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        if(wheremoving==1 || wheremoving ==3 || wheremoving ==4){
            transform.Translate(horizontalMove*Time.deltaTime,0f,0f);
        }
        else if(wheremoving==2 ){
            transform.Translate(-1f * horizontalMove*Time.deltaTime,0f,0f);
        }
        //moving(wheremoving,horizontalMove)l;
       
        //transform.Translate(horizontalMove*Time.deltaTime,0f,0f);
        if(Input.GetButtonDown("Jump") && transform.position.y < 2)
           { 
            rb.AddForce(new Vector3(0,45,0),ForceMode.Impulse);
                 
           }
    }
   

 
     // Code to execute after the delay
 
 void DedEnd(bool i){
    Application.LoadLevel("DedWon");
 }
    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "TransGround" )
        {
            cubeIsOnTheGround = true;}
       // ||collision.gameObject==null\
       // || collision.gameObject.GetComponent<Rigidbody>() == true
       if(collision.gameObject.tag == "Finish"){
           animator.SetBool("IsHit",true);
           Destroy(assassin, 2);
            
            DedEnd(true);
       }
      
   
        
    }}
