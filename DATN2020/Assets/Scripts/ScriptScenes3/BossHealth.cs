using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealth : MonoBehaviour
{
    public int health = 1000;
    public GameObject deathEffect;
    public GameObject dialogHealth, dialogHeart;
    Player player;

    public bool isInvulnerable = false;
    
    public void TakeDame(int Damage)
    {
        
        if (isInvulnerable)
             return;
        health -= Damage;
        if (health <= 200)
        {
            GetComponent<Animator>().SetBool("IsEnraged",true);
        }
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        dialogHealth.SetActive(false);
        dialogHeart.SetActive(false);
        Instantiate(deathEffect, transform.position, Quaternion.identity); 
        Destroy(gameObject);
        player.gm.points += 1000;
        if (PlayerPrefs.GetInt("highscore") < player.gm.points)
            PlayerPrefs.SetInt("highscore", player.gm.points);
    }
    //
    public Slider slider;

    public void setMaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void sethealth(int health)
    {
        slider.value = health;
    }
   
}
