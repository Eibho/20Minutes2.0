using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    //respawn
    public Transform respawnPoint;
    public GameObject player;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Respawn");

            StartCoroutine(Wait());

            
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = respawnPoint.transform.position;
    }
    
}

