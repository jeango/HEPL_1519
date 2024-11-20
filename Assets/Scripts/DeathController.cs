using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject deathEffect;
    public PowerupGenerator powerupGenerator;
    public int scoreValue;

    public void Kill()
    {
        //Instantiate an explosion
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Generate a powerup
        powerupGenerator?.GeneratePowerup(transform.position);
        //Gain points
        GameManager.score += scoreValue;
        //Destroy Object
        Destroy(gameObject);
    }
}
