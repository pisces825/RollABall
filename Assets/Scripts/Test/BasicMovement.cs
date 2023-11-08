using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
        Debug.Log(transform.position);
        transform.position = new Vector3(1, 1, 1);

        transform.position = transform.position + new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}