using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ucuncuitemtoplama : MonoBehaviour
{
    [SerializeField] private Animator kapý;
    [SerializeField] private string kapýacýk = "DoorOpen";
    [SerializeField] private string kapýdur = "Idle";
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
            kapý.Play(kapýacýk, 0, 0.0f);
        }
        
    }
}
