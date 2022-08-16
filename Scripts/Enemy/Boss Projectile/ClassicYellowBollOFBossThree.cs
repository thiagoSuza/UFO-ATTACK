using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicYellowBollOFBossThree : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody2D rbg;
    private float yspeed;
    // Start is called before the first frame update
    void Start()
    {
        yspeed = -120f;
        StartCoroutine("Ball");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Frag()
    {
        Instantiate(bullet,transform.position,transform.rotation * Quaternion.Euler(0f, 0f, 0f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 45f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 90f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 135f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 180f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 225f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 270f));
        Instantiate(bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 315f));
    }

    IEnumerator Ball()
    {
        rbg.AddForce(new Vector2(0f, yspeed));
        yield return new WaitForSeconds(3f);
        rbg.AddForce(new Vector2(0f, 0f));
        Frag();
        Destroy(gameObject);
        
    }
}
