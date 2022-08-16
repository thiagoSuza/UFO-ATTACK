using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERed : MonoBehaviour
{
    private int _damage;
    // Start is called before the first frame update
    void Start()
    {
        _damage = 17;
        Destroy(gameObject,15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 20f) * Time.deltaTime);
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
