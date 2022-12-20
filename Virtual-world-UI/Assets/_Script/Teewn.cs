using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teewn : MonoBehaviour
{
    public Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
        }
    }
}
