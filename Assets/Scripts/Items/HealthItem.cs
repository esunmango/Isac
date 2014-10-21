﻿using Assets.Scripts;
using UnityEngine;

public class HealthItem : ItemBase {

    [SerializeField]
    private int _healthAddition = 2;
    public int HealthAddition
    {
        get { return _healthAddition; }
        set { _healthAddition = value; }
    }

    protected override void OnPickUp(Player player)
    {
        base.OnPickUp(player);
        player.GetComponent<Player>().Health += HealthAddition;
    }
}
