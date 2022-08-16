
using UnityEngine;

public class Missil : MonoBehaviour
{
    private Rigidbody2D theRB;
    public Transform tgt = null;
    private float currentSpeed = 5f;
    public float sensorRange;
    public LayerMask layerMask;
    private float _speed = 3f;
    private int _damage;
    private bool lockON;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        _damage = 100;
        lockON = false;
    }

    // Update is called once per frame
    void Update()
    {
        Seek();
       Collider2D[] target =  Physics2D.OverlapCircleAll(transform.position, sensorRange, layerMask);
        if(target.Length > 0 && !lockON)
        {
            tgt = target[0].transform;
            lockON = true;
        }
    }

    public void Seek()
    {
        if(tgt != null )
        {
            transform.position = Vector2.MoveTowards(transform.position, tgt.position, currentSpeed * Time.deltaTime);
            Vector3 lookDirection = tgt.position - transform.position;
            float lookAngle = -Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            theRB.rotation = lookAngle;
        }else if(tgt == null)
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
        }
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
