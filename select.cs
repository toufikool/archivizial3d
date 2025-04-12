using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    // Start is called before the first frame update
    public void selction()
    {
        Debug.Log(transform.parent.GetSiblingIndex());
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
