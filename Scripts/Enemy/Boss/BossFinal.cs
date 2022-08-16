using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFinal : MonoBehaviour
{
    public static BossFinal instance;
    public Slider bossBarLife;
    public GameObject slider;
    public bool winGame;
    private int _health, currentLife;
    public GameObject finalText, bossTex;
    public Animator animator;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        BossIncomingSing();
        _health = 16000;
        bossBarLife.maxValue = _health;
        currentLife = _health;
        slider.SetActive(true);
        winGame = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        KIA();
        BarLife();
    }


    public void LoseHealthEnemy(int damage)
    {
        currentLife -= damage;

    }

    public void KIA()
    {
        if(currentLife <= 0)
        {
            winGame = true;
            slider.SetActive(false);
            Destroy(gameObject, 1f);
        }
    }

    public void BarLife()
    {
        bossBarLife.value = currentLife;
    }

    public void BossIncomingSing()
    {
        StartCoroutine("BossText");
        Destroy(bossTex);
        bossTex = null;

    }

    IEnumerator BossText()
    {
        finalText.SetActive(true);
        animator.SetBool("active", true);
        yield return new WaitForSeconds(8f);
        animator.SetBool("active", false);
        yield return new WaitForSeconds(3f);
        finalText.SetActive(false);
    }
}
