﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<ParticleSystem>().Play();
    }
}
