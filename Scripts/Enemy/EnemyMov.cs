using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public Rigidbody2D nave;
    public float xMove, xMinusMov;
    // Start is called before the first frame update
    void Start()
    {
        nave = GetComponent<Rigidbody2D>();
        InvokeRepeating("Action", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Action()
    {
        StartCoroutine("Mov");
    }

    IEnumerator Mov()
    {
        nave.AddForce(new Vector2(xMove,0f),ForceMode2D.Impulse);
        yield return new WaitForSeconds(1f);
        nave.AddForce(new Vector2(-xMinusMov, 0f), ForceMode2D.Impulse);

    }
}
