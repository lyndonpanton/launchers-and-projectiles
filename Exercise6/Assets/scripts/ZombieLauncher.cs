using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLauncher : Launcher
{
    // Start is called before the first frame update
    protected override void Start()
    {
        cooldownSeconds = 1f;
        base.Start();
    }
}
