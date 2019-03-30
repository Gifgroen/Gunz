
using UnityEngine;

[CreateAssetMenu(fileName = "Player stats", menuName = "Player/Stats", order = 1)]
public class PlayerStats: ScriptableObject
{
    public Vector3 MoveVelocity = Vector3.zero;
    public Vector3 LookAtPoint = Vector3.zero;

    public Gun equippedGun;
    public Gun startingGun;

    public void Equip(Gun gun, Transform hand)
    {
        if (equippedGun != null)
        {
            DestroyImmediate(equippedGun);
        }
        equippedGun = Instantiate(gun, hand.position, hand.rotation, hand.transform);
    }

    public void Shoot()
    {
        if (equippedGun != null)
        {
            equippedGun.Shoot();
        }
    }
}
