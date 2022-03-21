using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollision : MonoBehaviour
{


    private Collider[] hitColliders;
    // Start is called before the first frame update
    public float blastRadius;
    public float explosionPower;
    
    public LayerMask explosionLayers;

    

     void OnCollisionEnter(UnityEngine.Collision col){
        //if(col.gameObject.transform.root.CompareTag("Wall"))
      
    
        //if(col.collider.tag == "Wall")
        if(col.gameObject.transform.root.CompareTag("Wall")||col.gameObject.transform.root.CompareTag("Trans"))
        {
            Debug.Log("Hit Colission is working");
            destroy(col.GetContact(0).point);
            
            
        }

    }
    void destroy(Vector3 explosionPoint){
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

        foreach (Collider hitCol in hitColliders)
        {
            if (hitCol.GetComponent<Rigidbody>() == null){
                    hitCol.GetComponent<MeshRenderer>().enabled = true;
                    hitCol.gameObject.AddComponent<Rigidbody>();

                    hitCol.GetComponent<Rigidbody>().mass = 500;
                    hitCol.GetComponent<Rigidbody>().isKinematic = false;
                    Debug.Log("Destroy");

                    hitCol.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 5;
                    hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);
                    




                   

        }
        }
    } 
  
}
