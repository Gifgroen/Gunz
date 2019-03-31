using UnityEngine;

[CreateAssetMenu(fileName = "Player stats", menuName = "Player/Stats", order = 1)]
public class PlayerStats: ScriptableObject
{
    // Default params
    public float moveSpeed;
    public Gun startingGun;

    // State
    public Vector3 MoveVelocity = Vector3.zero;
    public Vector3 LookAtPoint = Vector3.zero;
    public Gun equippedGun;

    public void EquipStartingGun(Transform hand)
    {
        var gun = equippedGun ? equippedGun: startingGun; 
        Equip(gun, hand);
    }

    public void Equip(Gun gun, Transform hand)
    {
        equippedGun = Instantiate(gun, hand.position, hand.rotation, hand.transform);
    }

    public void Shoot()
    {
        if (equippedGun == null)
        {
            return;
        }
        equippedGun.Shoot();
    }
}
