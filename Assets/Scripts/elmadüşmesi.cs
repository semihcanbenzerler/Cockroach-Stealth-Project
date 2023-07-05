using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elmadüşmesi : MonoBehaviour
{
    public GameObject ayakcollideri;
    public GameObject elma;
    public Rigidbody elmanınrigid;
    public float forcepower;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            elmanınrigid.AddForce(0, 0, forcepower);
        }
        Object.Destroy(ayakcollideri);
    }
}
