using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EYellow : MonoBehaviour
{
    
    private float speed;
    public GameObject explosionPS,explosionGO;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * transform.up;
        Explosion();
    }

    public void Explosion()
    {
        if (speed >= 0)
        {
            speed -= 2f * Time.deltaTime;
        }
        else
        {
            
            speed = 0;
            Instantiate(explosionPS,transform.position,transform.rotation);            
            Instantiate(explosionGO,transform.position,transform.rotation);            
            Destroy(gameObject);

        }
    }

    
}
