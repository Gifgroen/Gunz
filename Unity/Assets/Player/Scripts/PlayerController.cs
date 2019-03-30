using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerStats playerStats;

    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        playerRigidbody.MovePosition(playerRigidbody.position + playerStats.MoveVelocity * Time.fixedDeltaTime);
        playerRigidbody.transform.LookAt(playerStats.LookAtPoint);
    }
}
