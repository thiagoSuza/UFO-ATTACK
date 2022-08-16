using UnityEngine;

public class EPurple : MonoBehaviour
{
    private int _damage;
    private float _timeToDestroy;

    private void Start()
    {
        _damage = 400;
        _timeToDestroy = .15f;
        Destroy(gameObject, _timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().LoseHealthEnemy(_damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Boss"))
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
