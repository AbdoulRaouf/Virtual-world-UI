using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dotween : MonoBehaviour
{
    [SerializeField] Ease ease;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(0, 0, 10), 2).SetEase(ease).SetLoops(-1); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
