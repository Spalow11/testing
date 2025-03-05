using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 100;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока = " + health);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    public void CollectCoins()
    {
        coins++;
        print(coins);
    }
}


