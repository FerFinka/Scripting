using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballprefab;
    public Transform attackPoint;
    private int health = 10;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballprefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
        
    }
}
