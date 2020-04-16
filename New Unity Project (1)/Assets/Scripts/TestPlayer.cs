using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    // using integers to define a players HP in relation to the health bar
    public int maxHealth = 20;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {   // changes health to the variable currentHealth when Health is < Max Health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {  // pressing Up Arrow will inflict damage to the player, moving the health bar
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           TakeDamage(5);
        }
        
    }
    // current health is shown to be reduced on the # of  damage taken
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }



}

