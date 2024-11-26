using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PowerupGenerator : MonoBehaviour
{
    public List<GameObject> powerups;
    [Range(0f,1f)]
    public float powerupProbability;
    
    private static List<GameObject> _activePowerups = new List<GameObject>();

    void Start()
    {
        _activePowerups.Clear();
    }
    
    public static void ActivatePowerup(GameObject powerup, bool active)
    {
        if (!powerup)
        {
            return;
        }
        var containsPowerup = _activePowerups.Contains(powerup);
        if (active && !containsPowerup)
        {
            _activePowerups.Add(powerup);
            return;
        }
        if (!active && containsPowerup)
        {
            _activePowerups.Remove(powerup);
        }
    }
    
    public GameObject GeneratePowerup(Vector3 position)
    {
        var roll = Random.Range(0f, 1f);
        if (roll > powerupProbability)
        {
            return null;
        }
        var validPowerups = powerups.Except(_activePowerups).ToArray();
        if (validPowerups.Length == 0)
        {
            return null;
        }
        return Instantiate(validPowerups[Random.Range(0, validPowerups.Length)], position, Quaternion.identity);
    }
}
