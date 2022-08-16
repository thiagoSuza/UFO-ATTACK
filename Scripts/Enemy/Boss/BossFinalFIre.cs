using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFinalFIre : MonoBehaviour
{
    public GameObject bulletBall, bulletStar;
    public Transform c1;
    public Animator anim;
    private int randomMov;
    private float timer, timerMax;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("ok", true);
        timerMax = 15f;
        timer = timerMax;
        InvokeRepeating("Action", 9f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        Mov();
    }
    public void Mov()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            randomMov = Random.Range(0, 2);
            if(randomMov == 1)
            {
                anim.SetTrigger("movOne");
            }else if(randomMov == 2)
            {
                anim.SetTrigger("movTwo");
            }
            timer = timerMax;
        }
    }

   

    public void Action()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 360; j += 20)
            {
                Instantiate(bulletStar, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, j));
            }
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(2f);
        
       
        for(int i = 0; i < 10; i++)
        {
            Instantiate(bulletBall,transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -40f));
            Instantiate(bulletBall, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -20f));
            Instantiate(bulletBall, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 0f));
            Instantiate(bulletBall, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 20f));
            Instantiate(bulletBall, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 40f));
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(2f);
        
       
        
    }


}
