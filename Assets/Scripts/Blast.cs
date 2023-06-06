using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Blast : MonoBehaviour
{

    public Rigidbody2D projectile;

    public float bulletSpeed;
    public GameObject bazooka;
    public GameObject missilePrefab;
    public AudioSource bazookaSpeaker;
    public AudioClip launch;
    public float launchVolume;

    float cooldown;

    void Start()
    {
       
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        cooldown -= Time.deltaTime;

    }


    private void Shoot()
    {
        if (cooldown <= 0)
        {
            cooldown = 0.5f;
            bazookaSpeaker.PlayOneShot(launch, launchVolume);
            Rigidbody2D clone;
            clone = Instantiate(projectile, transform.position, bazooka.transform.rotation);

            clone.velocity = transform.right * bulletSpeed;
        }
            
    }


}
