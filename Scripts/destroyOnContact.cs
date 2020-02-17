using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyOnContacts", 2f);
    }
    void destroyOnContacts()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
