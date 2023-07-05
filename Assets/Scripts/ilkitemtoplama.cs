using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ilkitemtoplama : MonoBehaviour
{
    public GameObject player;
    public GameObject bırıncıduvar;
    int puan = 0;
    public TextMeshProUGUI textmeshprogui;

    private void Start()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {

            Destroy(collision.gameObject);
            puan++;
            textmeshprogui.text = "Collect everything : " + puan.ToString() + "/5";
        }

        if (puan == 5)
        {
            Destroy(bırıncıduvar);
            puan = 0;
            textmeshprogui.text = "Collect everything : " + puan.ToString() + "/6";
            Destroy(this);
        }

    }
}
