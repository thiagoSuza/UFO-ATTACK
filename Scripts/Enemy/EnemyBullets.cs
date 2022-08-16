using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public BulletEnemy be;
    private int _damage, _speed;

    // Start is called before the first frame update
    void Start()
    {
        _damage = be.damage;
        _speed = be.speed;
    }

    private void Update()
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
