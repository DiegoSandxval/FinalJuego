using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject bullet;

    public float shotForce = 1500f;

    public float shotRate = 0.5f;
    private AudioSource audioSource;
    public AudioClip shotSound;
    private float shotRateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioSource.PlayOneShot(shotSound);
            if (Time.time > shotRateTime && GameManager.Instance.gunAmmo > 0)
            {

                GameManager.Instance.gunAmmo--;
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet, 5);
            }
        }
    }
}
