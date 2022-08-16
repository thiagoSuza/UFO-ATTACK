using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInfoOfBullet : MonoBehaviour
{
    private int _damage, _speed;
    public BulletEnemy bInfo;
    // Start is called before the first frame update
    void Start()
    {
        _damage = bInfo.damage;
        _speed = bInfo.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerOneLife.instance.LoseHealth(_damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            PlayerTwoLife.instance.LoseHealth(_damage);
            Destroy(gameObject);
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
