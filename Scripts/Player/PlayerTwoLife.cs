using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoLife : MonoBehaviour
{
    public static PlayerTwoLife instance;
    private int healthMax, lifes;
    public Text lifeText;
    public bool gameOver;
    public int currentLife;
    public Slider healthBar;
    public Animator animator;
    public GameObject panelHUD, PanelKIA;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        healthMax = 150;
        currentLife = healthMax;
        healthBar.maxValue = healthMax;
        healthBar.value = currentLife;
        gameOver = false;
        lifes = 4;
        lifeText.text = lifes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoseHealth(int damage)
    {
        currentLife -= damage;
        healthBar.value = currentLife;
        if (currentLife <= 0)
        {
            LoseLifes();

        }

    }

    public void LoseLifes()
    {
        if (lifes > 0)
        {
            lifes--;
            animator.SetTrigger("LoseLife");
            lifeText.text = lifes.ToString();
            currentLife = healthMax;
            healthBar.value = currentLife;
        }
        else if (lifes == 0)
        {
            gameObject.SetActive(false);
            gameOver = true;
            panelHUD.SetActive(false);
            PanelKIA.SetActive(true);
        }
    }

    public void UpHealth()
    {
        int x = Random.Range(30,100 );
        currentLife += x;
        healthBar.value = currentLife;
        if(currentLife > healthMax)
        {
            currentLife = healthMax;
        }
    }

    public void UpLife()
    {
        lifes++;
        lifeText.text = lifes.ToString();
    }

    public void Reborn()
    {
        gameObject.SetActive(true);
        gameOver = false;
        panelHUD.SetActive(true);
        PanelKIA.SetActive(false);
        currentLife = healthMax;
        healthBar.value = currentLife;
        lifes++;
        lifeText.text = lifes.ToString();
    }
}
