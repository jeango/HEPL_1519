using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivatePowerUp : MonoBehaviour
{
    public GameObject powerUp;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        var activePowerUp = Instantiate(powerUp, other.gameObject.transform.position, Quaternion.identity);
        //if (activePowerUp == child)
        activePowerUp.transform.parent = other.gameObject.transform;
        
        Destroy(gameObject);
    }
    
}
