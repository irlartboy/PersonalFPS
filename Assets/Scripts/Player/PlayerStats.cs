using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth;
    public static float curHealth;

    public Image healthFill;

    public GameObject hurtPanel;

    void Start()
    {
        maxHealth = 100;
        curHealth = 100;

    }

    void Update()
    {
        healthFill.fillAmount = Mathf.Clamp01(curHealth / maxHealth);
        if (curHealth <= 25 )
        {
            hurtPanel.SetActive(true);
        }   
        else
        {
            hurtPanel.SetActive(false);
        }
    }

   /* public void ManageHealthBar()
    {
        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled && curHealth > 0)
        {
            healthFill.enabled = enabled;
        }
    }*/
}
