using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject theBullet;
    public Transform barrelEnd;

    private GameObject triggeringObject;

    public int bulletSpeed = 900;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 10.25f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (shootAble)
            {
                shootAble = false;
                Shoot();
                StartCoroutine(ShootingYield());
            }
        }
    }

    IEnumerator ShootingYield()
    {
        yield return new WaitForSeconds(waitBeforeNextShot);
        shootAble = true;
    }
    void Shoot()
    {
        var bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}