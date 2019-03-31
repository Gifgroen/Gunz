using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    private PlayerStats playerStats;

    [SerializeField] 
    private Transform hand;

    private void Start()
    {
        playerStats.EquipStartingGun(hand);
    }
}
