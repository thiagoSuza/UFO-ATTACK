using UnityEngine;

public class EBlue : MonoBehaviour
{
    private int _damage;
    private float _timeToDestroy;

    private void Start()
    {
        _damage = 12;
        _timeToDestroy = 8f;
        Destroy(gameObject, _timeToDestroy);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().LoseHealthEnemy(_damage);
            
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LoseHealthEnemy(_damage);
            
        }
        else if (collision.gameObject.CompareTag("FinalBoss"))
        {
            collision.gameObject.GetComponent<BossFinal>().LoseHealthEnemy(_damage);
            
        }
        else if (collision.gameObject.CompareTag("AST"))
        {
            collision.gameObject.GetComponent<AsteroidClassic>().LoseLifeAST(_damage);
            
        }
    }
}
