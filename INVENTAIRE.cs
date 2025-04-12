using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INVENTAIRE : MonoBehaviour
{
    // Start is called before the first frame update
    private bool activation = false;
    void Start()
    {
          
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activation = !activation;

         
            GetComponent<Canvas>().enabled = activation;

        }

    }
}
