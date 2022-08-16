using UnityEngine;

public class SpeedAndDamageOfBullet : MonoBehaviour
{
    public DamageSpeedOfBulletes info;
    private int _damage, _speed;
    

    // Start is called before the first frame update
    void Start()
    {
        _damage = info.damage;
        _speed = info.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);   
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().LoseHealthEnemy(_damage);
            Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LoseHealthEnemy(_damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("FinalBoss"))
        {
            collision.gameObject.GetComponent<BossFinal>().LoseHealthEnemy(_damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("AST"))
        {
            collision.gameObject.GetComponent<AsteroidClassic>().LoseLifeAST(_damage);
            Destroy(gameObject);
        }

        
    }
}
