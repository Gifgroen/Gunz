
using UnityEngine;

[CreateAssetMenu(fileName = "Player stats", menuName = "Player/Stats", order = 1)]
public class PlayerStats: ScriptableObject
{
    public Vector3 MoveVelocity = Vector3.zero;
    public Vector3 LookAtPoint = Vector3.zero;

}