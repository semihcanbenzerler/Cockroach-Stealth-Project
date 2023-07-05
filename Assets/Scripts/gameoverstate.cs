using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverstate : MonoBehaviour
{   
    
    public GameObject gameovertitle;
    public GameObject saklanma;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            Time.timeScale = 0;
            gameovertitle.SetActive(true);
            saklanma.SetActive(false);


        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("FinalLevelDesign");
            Time.timeScale = 1;
        }
    }
}
