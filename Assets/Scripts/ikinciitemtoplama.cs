using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ikinciitemtoplama : MonoBehaviour
{
    public GameObject ıkıncıduvar;
    int puan = 0;
    public TextMeshProUGUI textmeshprogui;

    private void Start()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("seconditem"))
        {

            Destroy(collision.gameObject);
            puan++;
            textmeshprogui.text = "Collect everything : " + puan.ToString() + "/6";
        }

        if (puan == 6)
        {
            Destroy(ıkıncıduvar);
            puan = 0;
            textmeshprogui.text = "Collect everything : " + puan.ToString() + "/7";
        }

    }
}
