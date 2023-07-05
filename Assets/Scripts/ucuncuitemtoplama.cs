using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ucuncuitemtoplama : MonoBehaviour
{
    [SerializeField] private Animator kap�;
    [SerializeField] private string kap�ac�k = "DoorOpen";
    [SerializeField] private string kap�dur = "Idle";
    public GameObject player;
    int puan = 0;
    public TextMeshProUGUI textmeshprogui;

    private void Start()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("thirditem"))
        {

            Destroy(collision.gameObject);
            puan++;
            textmeshprogui.text = "Collect everything : " + puan.ToString() + "/7";
        }

        if (puan == 7)
        {
            kap�.Play(kap�ac�k, 0, 0.0f);
        }
        
    }
}
