using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGenerator : MonoBehaviour
{
    public List<GameObject> powerUps;
    [Range(0f, 1f)]
    public float powerUpProbability;
    
    private static List<GameObject> _activePowerUps = new List<GameObject>();

    void Start()
    {
        _activePowerUps.Clear();
    }
    
    public static void ActivatePowerUp(GameObject powerUp, bool active)
    {
        if (!powerUp)
        {
            return;
        }

        var containsPowerUp = _activePowerUps.Contains(powerUp);

        if (active && !containsPowerUp)
        {
            _activePowerUps.Add(powerUp);
            return;
        }

        if (!active && containsPowerUp)
        {
            _activePowerUps.Remove(powerUp);
        }
    }

    public GameObject GeneratePowerUp(Vector3 position)
    {
        var roll = Random.Range(0f, 1f);
        if (roll < powerUpProbability)
        {
            return null;
        }
        var validPowerUps = powerUps.Except(_activePowerUps).ToArray();
        if (validPowerUps.Length == 0)
        {
            return null;
        }
        return Instantiate(validPowerUps[Random.Range(0, validPowerUps.Length)], position, Quaternion.identity);
    }
}
