using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Boss : MonoBehaviour
{
    public Slider bossBarLife;
    public GameObject bossBar,tmsproTextObject;
    [SerializeField]
    private int _health;    
    public GameObject nextLevel;
    public Animator animator;
    public GameObject expl;
    private int _scorePoint;
    private int currentLife;


    void Start()
    {
        bossBar.SetActive(true);
        BossIncomingSing();        
        currentLife = _health;
        bossBarLife.maxValue = _health;

    }

    
    void Update()
    {
        KIA();
        BarLife();
    }

    public void KIA()
    {
        if(currentLife <= 0)
        {
            nextLevel.SetActive(true);
            Destroy(bossBar);
            Instantiate(expl,transform.position, Quaternion.identity);
            ClassicScoreController.instance.ScoreUp(_scorePoint);
            Destroy(gameObject);
        }
    }

    public void LoseHealthEnemy(int damage)
    {
        currentLife -= damage;

    }

    public void BarLife()
    {
        bossBarLife.value = currentLife;
    }

    public void BossIncomingSing()
    {
        StartCoroutine("BossText");

    }

    IEnumerator BossText()
    {
        tmsproTextObject.SetActive(true);
        animator.SetBool("active", true);        
        yield return new WaitForSeconds(8f);
        animator.SetBool("active", false);
        yield return new WaitForSeconds(3f);
        tmsproTextObject.SetActive(false);
    }
}
