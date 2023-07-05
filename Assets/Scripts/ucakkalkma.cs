using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucakkalkma : MonoBehaviour
{
    [SerializeField] private Animator plane;
    [SerializeField] private string planedepart = "plane";
    public GameObject player;
    
    

    private void Start()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("thirditem"))
        {
            plane.Play(planedepart, 0, 0.0f);
        }
    }
}
