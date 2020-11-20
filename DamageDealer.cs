﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int damage = 100;

    public int GetDamage()
    {
        return damage;
    }

    public void hit()
    {
        Destroy(gameObject);
    }
}
