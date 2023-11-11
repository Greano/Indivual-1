using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Turret : IShootable, Ipersitable
{
    public void Fire()
    {
        Debug.Log("Turret Fires");
    }
    public void Save()
    {
        Debug.Log("Turret Saved");
    }
}
