using UnityEngine;
using UnityEngine.InputSystem;

public class ShotBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 10f;

    private InputAction shootAction;


    private void OnShoot(InputAction.CallbackContext context)
    {
       
        if (context.performed)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
      
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody bulletRigidbody = bulletInstance.GetComponent<Rigidbody>();


       
            bulletRigidbody.velocity = firePoint.forward * bulletSpeed;
       
    }
}