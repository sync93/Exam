﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int scoreValue = 1;
    private SpawnObject spw;
    public AudioClip deathSound;
    Animator anim;
    AudioSource enemyAudio;
    public float timer = 150f;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }
        void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
            if (timer < 150 && timer > 120)
            {
                ScoreManager.score1 += scoreValue;
            }
            if (timer < 120 && timer>90) {
                ScoreManager.score2 += scoreValue;
            }
            if (timer < 90 && timer > 60)
            {
                ScoreManager.score3 += scoreValue;
            }
            if (timer < 60 && timer > 30)
            {
                ScoreManager.score4 += scoreValue;
            }
            if (timer < 30 && timer > 0)
            {
                ScoreManager.score5 += scoreValue;
            }
            //ScoreManager.score += scoreValue;

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
        Destroy(gameObject, 1f);
    }

}
