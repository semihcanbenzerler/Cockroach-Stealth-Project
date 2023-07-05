using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saklanma : MonoBehaviour
{
    public GameObject ModelPanel;
    Movement playerController;
    

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        ModelPanel.SetActive(false);
        playerController = player.GetComponent<Movement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           transform.position = new Vector3(-15.7f, 0.1976466f, 27.03f);
           
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
           transform.position = new Vector3(-16.1f, 0.1976466f, 27.03f);
           playerController.gameObject.SetActive(true);
        }
        
    }

    
    public void OnTriggerEnter(Collider self)
    {
        this.ModelPanel.SetActive(true);
        if (this.name == "trashbin")
        {
            
        }
    }
    void OnTriggerExit()
    {
        ModelPanel.SetActive(false);
    }
}   
