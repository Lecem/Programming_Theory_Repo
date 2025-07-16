using UnityEngine;

// INHERTIANCE
public class SkipRoundPowerUp : PowerUp
{
    protected override void Execute()
    {
        _boxManager.SkipRound();
    }
}
