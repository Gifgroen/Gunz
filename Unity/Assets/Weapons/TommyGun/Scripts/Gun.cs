using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField]
    private Transform muzzle;

    [SerializeField]
    private Projectile projectile;

    [SerializeField]
    private float msBetweenShots = 100f;

    [SerializeField]
    private float velocity;

    
    private float _nextShotTime;
    
    public void Shoot()
    {
        if (Time.time <= _nextShotTime) return;
        
        _nextShotTime = Time.time + msBetweenShots / 1000;
        var newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation);
        newProjectile.SetSpeed(velocity);
    }
}
