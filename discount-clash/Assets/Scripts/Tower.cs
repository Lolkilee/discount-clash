using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float health;
    public float attackDmg;
    public bool isKingTower = true;
    private bool isActivated = false;    

    void Start()
    {
        if(!isKingTower) isActivated = true;
    }

    void Update()
    {
        if(isKingTower && health < 5000) isActivated = true;
        if(health <= 0) Destroy(gameObject); //To be improved
    }

    public void OnDamage(float amountOfDamage)
    {
        health -= amountOfDamage;
    }
}
