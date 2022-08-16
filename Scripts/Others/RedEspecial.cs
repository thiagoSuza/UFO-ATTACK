using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEspecial : MonoBehaviour
{
    public GameObject explosion;
    private float timer;
    private bool isExploded;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = 2f;
        isExploded = false;
    }

    // Update is called once per frame
    void Update()
    {
        Mov();
        Exploded();
    }

    public void Mov()
    {
        while(timer > 0)
        {
            timer -= Time.deltaTime;
            transform.Translate(Vector2.up * 1 * Time.deltaTime);
        }
    }  public void Exploded()
    {
        if(timer <= 0 && !isExploded)
        {
            Instantiate(explosion,transform.position,transform.rotation);
            isExploded = true;
            
        }
        Destroy(gameObject,2);
    }
}
