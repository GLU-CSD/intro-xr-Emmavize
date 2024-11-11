using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image HeatlthbarFill;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();

    }

    void Update()
    {
        
    }

    void UpdateHealthBar()
    {
        HeatlthbarFill.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
    public void RestoreHeatlh(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
}

