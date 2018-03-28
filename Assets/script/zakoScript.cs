﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zakoScript : MonoBehaviour
{
    bool hitFlag = false;
    public ParticleSystem dethEffect;
    public float dethTime = 90.0f;
    // Use this for initialization
    void Start()
    {
        dethEffect.transform.position = this.gameObject.transform.position;
        dethEffect.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "weaponSword")
        {
            hitFlag = true;
         
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (hitFlag)
        {
            Instantiate(this.dethEffect, this.transform.position, this.transform.rotation);
            Debug.Log("雑魚の叫び: うあ～");
            Destroy(this.gameObject);
            ;
        }
    }
}
