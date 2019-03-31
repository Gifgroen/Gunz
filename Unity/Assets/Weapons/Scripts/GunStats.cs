using UnityEngine;

[CreateAssetMenu(menuName = "Gun/Stats", fileName = "New gun", order = 1)]
public class GunStats : ScriptableObject
{
    public Projectile projectile;

    public float msBetweenShots = 500f;

    public float velocity = 10f;
}
