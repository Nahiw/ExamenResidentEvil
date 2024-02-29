using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletSpawnPointPrefab;
    public float bulletspeed = 0;

    private void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            var bullet = Instantiate(bulletSpawnPointPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
        }
    }
}
