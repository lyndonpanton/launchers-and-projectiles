using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateProjectile : Projectile
{
    // Start is called before the first frame update
    protected override void Start()
    {
        impulseForce.x = 3;
        base.Start();
    }
}
