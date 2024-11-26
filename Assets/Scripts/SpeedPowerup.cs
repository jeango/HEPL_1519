using UnityEngine;
using System.Collections;

public class SpeedPowerup : Powerup
{
    public int speedBonus;
    public float bonusDuration;
    
    public override void Activate()
    {
        base.Activate(); 
        StartCoroutine(SpeedUp());
    }

    public override void Deactivate()
    {
        base.Deactivate();
        Destroy(this);
    }
    
    IEnumerator SpeedUp()
    {
        var mvtCtrl = transform.parent.GetComponent<MovementController>();
        if(!mvtCtrl) yield break;
        mvtCtrl.Speed += speedBonus;
        yield return new WaitForSeconds(bonusDuration);
        mvtCtrl.Speed -= speedBonus;
        Deactivate();
    }
}