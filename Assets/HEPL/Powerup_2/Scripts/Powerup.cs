using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject pickupPrefab;
    
    public virtual void Activate()
    {
        PowerupGenerator.ActivatePowerup(pickupPrefab, true);
    }

    public virtual void Deactivate()
    {
        PowerupGenerator.ActivatePowerup(pickupPrefab, false);
    }
}