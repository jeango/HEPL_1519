using UnityEngine;

public class ShieldedDeathController : DeathController
{
    public override void Kill()
    {
        var shield = GetComponentInChildren<Shield>();
        if (shield)
        {
            Destroy(shield.gameObject);
            
            return;
        }
        base.Kill();
    }
    
}
