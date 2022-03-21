using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseControl : MonoBehaviour
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
    

   
     
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("LeftandRight")*runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        transform.Translate(horizontalMove*Time.deltaTime,0f,0f);
        if(Input.GetButtonDown("Jump") && cubeIsOnTheGround){
            rb.AddForce(new Vector3(0,45,0),ForceMode.Impulse);
            cubeIsOnTheGround = false;
            
        
        }

    }
     public void Ded(bool x){
        if(x == true){
            Application.LoadLevel("DedWon");
        }
        
    }
    void FixedUpdate(){
       
        
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "TransGround" ){
            cubeIsOnTheGround = true;}
       // ||collision.gameObject==null
       if(collision.gameObject.name == "hammer01"  || collision.gameObject.GetComponent<Rigidbody>() == true)
        {

            Debug.Log("Hit Colission is working");
            
            animator.SetBool("IsHit",true);
            isDead=true;
            Destroy(assassin,2);
           
            Ded(isDead);
            
           
            
            
        }
    }
   
        
    }
