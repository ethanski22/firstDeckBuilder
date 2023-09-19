using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserStats : MonoBehaviour
{
    public Keyboard keyboard;

    void Start()
    {
        keyboard = Keyboard.current;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("You pressed the T key");
            TakeDamage(10);
        }
    }

    public int maxHealth = 100;
    public int currentHealth {  get; private set; }
    public bool isAlive { get; private set; }

    public Stats damage;
    public Stats armor;

    void Awake()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " +  damage + " damage!");

        if (currentHealth < 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    public virtual void Die()
    {
        isAlive = false;
        Debug.Log(transform.name + " died");
    }
}
