using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{
    float maxspeed = 0.01f;
    public float speed = .01f;

    private void Start()
    {
    }
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        if (maxspeed > 0.01)
        {
            maxspeed = 0.01f;
        }

        transform.Translate(-new Vector3(0.0f, 0, zDirection) * speed);
        transform.Rotate(0, xDirection * 6, 0);

    }
}
