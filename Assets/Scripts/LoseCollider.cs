﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;

    private void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Triiger");
        levelManager.LoadLevel("Lose Screen");

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
