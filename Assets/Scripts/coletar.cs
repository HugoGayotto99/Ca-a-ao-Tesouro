using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletar : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    void OnTriggerEnter (Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
