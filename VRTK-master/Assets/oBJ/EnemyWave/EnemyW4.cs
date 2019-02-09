using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyW4 : MonoBehaviour
{
    public int scoreValue = 1;
    private SpawnObject spw;
    public AudioClip deathSound;
    Animator anim;
    AudioSource enemyAudio;
    
    public float lifetime;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(GameObject.Find("enemyW4(Clone)"), lifetime);

    }
    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
           
                ScoreManager.score4 += scoreValue;
            
           

            gameObject.GetComponent<BoxCollider>().enabled = false;

            Death();
            spw.count--;
        }


    }

    public void Death()
    {

        anim.SetTrigger("Dead");
        enemyAudio.PlayOneShot(deathSound);
        Dyin();
    }


    public void Dyin()
    {
        rb.AddForce(0, 2.5f, 0, ForceMode.VelocityChange);
        Destroy(gameObject, 1f);
    }
}
