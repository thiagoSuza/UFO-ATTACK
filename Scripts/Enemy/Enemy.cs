using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy instance;

    private int _health;
    [SerializeField]
    private float _FireRate;
    public GameObject explosion;
    private GameObject _bullet;
    private GameObject[] _refillPack;
    private int _scorePoint;

    public EnemyInfo eInfo;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _scorePoint = eInfo.scorePoint;
        _FireRate = eInfo.fireRate;
        _bullet = eInfo.bullet;
        _health = eInfo.health;
        _refillPack = eInfo.refilPack;
    }

    // Update is called once per frame
    void Update()
    {
        Death();
        Fire();
    }


    public void LoseHealthEnemy(int damage)
    {
        _health -= damage;      
              
    }

    public void Death()
    {
        if(_health <= 0)
        {
            Instantiate(explosion,transform.position,transform.rotation);
            int x = Random.Range(0, 20);
            if(x < 5)
            {
                int y = Random.Range(0, _refillPack.Length);
                Instantiate(_refillPack[y],transform.position,transform.rotation);
            }
            ClassicScoreController.instance.ScoreUp(_scorePoint);
            OthersAudio.instance.explosionSound();
            Destroy(gameObject);
        }
    }


    public void Fire()
    {
        _FireRate -= Time.deltaTime;

        if(_FireRate <= 0)
        {
            Instantiate(_bullet,transform.position,transform.rotation);
            _FireRate = eInfo.fireRate; 
        }
    }
}
