using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }
    public float Speed = 20;

        // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *  speed);
    }
}