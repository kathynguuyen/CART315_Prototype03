using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public AudioSource pickupSound;
    private void OnTriggerEnter(Collider other)
    {
        pickupSound.Play();
        Destroy(gameObject);
    }

}

