using UnityEngine;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class PlayerInput : MonoBehaviour
{
    private struct Constants
    {
        public const int LEFT_MOUSE_BUTTON_INDEX = 0;
        public const string HORIZONTAL = "Horizontal";
        public const string VERTICAL = "Vertical";
    }

    [SerializeField]
    private PlayerStats stats;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        Move();
        LookAt();
        Shoot();
    }

    private void Move()
    {
        var rawMovement = new Vector3(
                Input.GetAxisRaw(Constants.HORIZONTAL),
                0f,
                Input.GetAxisRaw(Constants.VERTICAL));
        stats.MoveVelocity = rawMovement.normalized * stats.moveSpeed;
    }

    private void LookAt()
    {
        var groundPlane = new Plane(Vector3.up, Vector3.zero);
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (groundPlane.Raycast(ray, out var rayDistance))
        {
            var mousePoint = ray.GetPoint(rayDistance);
            stats.LookAtPoint = new Vector3(mousePoint.x, transform.position.y, mousePoint.z);;
        }
    }

    private void Shoot()
    {
        if (Input.GetMouseButton(Constants.LEFT_MOUSE_BUTTON_INDEX))
        {
            stats.Shoot();
        }
    }
}
