using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidClassic : MonoBehaviour
{
    private int health,number;
    public GameObject[] dropCrystal;
    public Animator animator;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(70, 90);
        number = 0;
        score = health;
    }

    // Update is called once per frame
    void Update()
    {
        Destroyed();
        transform.Rotate(new Vector3(0f, 0f,20f ) * Time.deltaTime);

    }

    public void Destroyed()
    {
        
        if(health <= 0 && number !=1)
        {
            number = 1;
            StartCoroutine("ASTExplode");

        }
    }

    public void LoseLifeAST(int damage)
    {
        health -= damage;
    }

    IEnumerator ASTExplode()
    {
        int x = Random.Range(0, 10);
        int y = Random.Range(0, dropCrystal.Length);
        if (x <= 3)
        {
            Instantiate(dropCrystal[y], transform.position, transform.rotation);
        }
        animator.SetTrigger("isDead");
        ClassicScoreController.instance.ScoreUp(score);
        yield return new WaitForSeconds(.4f);
        Destroy(gameObject);
    }
}
