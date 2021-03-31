using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private float speed = 5.0f;
    private float boundX = 45.0f;
    private Vector3 startPos = new Vector3(-49.8f, 2.7f, -0.4f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        if (transform.position.x > boundX)
        {
            transform.position = startPos;
        }
    }
}
