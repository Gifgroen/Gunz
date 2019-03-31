using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField]
    private Transform muzzle;

    [SerializeField]
    private GunStats stats;
    
    private float _nextShotTime;
    
    public void Shoot()
    {
        if (Time.time <= _nextShotTime) return;
        
        _nextShotTime = Time.time + stats.msBetweenShots / 1000;
        var newProjectile = Instantiate(stats.projectile, muzzle.position, muzzle.rotation);
        newProjectile.SetSpeed(stats.velocity);
    }
}
