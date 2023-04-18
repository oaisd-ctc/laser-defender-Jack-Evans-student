using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerShake : MonoBehaviour
{

    [SerializeField] float shakeDuration = 1f;
    [SerializeField] float shakeMagnitude = 0.5f;


    Vector3 initialPostion;
   
    void Start()
    {
        initialPostion = transform.position;
    }

  public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {

    }
}
