using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletMovement : MonoBehaviour
{
    Rigidbody rbbullet;
    float bulletspeed = 50.0f;
    public GameObject pinkParticleEffect;
    public AudioClip sound;
    AudioSource Bulletaudio;
  
    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody>();
        Bulletaudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rbbullet.velocity = Vector3.forward * bulletspeed;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Bulletaudio.clip = sound;
            Bulletaudio.Play();
          
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(pinkParticleEffect, transform.position, Quaternion.identity);
        }
        else
        {

            StartCoroutine("BulletAddToPool");
        }

    }
    IEnumerator BulletAddToPool()
    {
        yield return new WaitForSeconds(2);

        if (rbbullet.gameObject.name == "Bullet")
        {
            BulletSpawn.Instance.AddToPool(rbbullet.gameObject);
        }
    }
}