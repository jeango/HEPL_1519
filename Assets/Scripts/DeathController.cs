using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject deathEffect;
    public int scoreValue;

    public void Kill()
    {
        //Instantiate an explosion
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Gain points
        GameManager.score += scoreValue;
        //Destroy Object
        Destroy(gameObject);
    }
}
