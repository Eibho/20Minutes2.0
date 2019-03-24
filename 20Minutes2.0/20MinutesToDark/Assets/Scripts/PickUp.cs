using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject PlayerKey;
    public GameObject pickUpKey;

    private void Start()
    {
        PlayerKey.SetActive(false);
        pickUpKey.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerKey.SetActive(true);
            pickUpKey.SetActive(false);
        }
    }
}
