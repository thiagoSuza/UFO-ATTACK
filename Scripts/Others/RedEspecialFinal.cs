using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEspecialFinal : MonoBehaviour
{
    public GameObject explosionPS;
    private int damage;    
    private bool explode;
    public float speed;

    void Start()
    {
        
        explode = false;
        damage = 0;
    }


    void Update()
    {
        transform.position += speed * Time.deltaTime * transform.up;
        Move();
        Explosion();
    }


    public void Explosion()
    {
        if (explode)
        {
            damage = 1200;

            // REMOVER ISSO DEPOIS
            if(damage > 10000)
            {
                Debug.Log("BOM");
            }
            // FINAL

            Instantiate(explosionPS, transform.position, transform.rotation);
            Destroy(gameObject);
        }


    }

    public void Move()
    {
        if (speed >= 0)
        {
            speed -= 2f * Time.deltaTime;
        }
        else
        {

            speed = 0;
            explode = true;



        }

    }
}
