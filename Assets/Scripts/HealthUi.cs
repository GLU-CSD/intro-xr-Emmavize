using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUi : MonoBehaviour
{
    public string prefabTag = "Enemy";
    private Health healthScript;
    void Start()
    {
        
    }

    void Update()
    {
        if (healthScript == null)
        {
            GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
            if (spawnedPrefab != null)
            {
                healthScript = spawnedPrefab.GetComponent<Health>();
            }
        }
    }
   
    public void DamageButton()
    {
        if (healthScript != null)
        {
            healthScript.TakeDamage(10); 
        }
    }

    public void HealButton()
    {
        if (healthScript != null)
        {
            healthScript.RestoreHeatlh(10); 
        }
    }

}
