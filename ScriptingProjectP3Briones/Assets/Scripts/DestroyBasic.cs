using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
