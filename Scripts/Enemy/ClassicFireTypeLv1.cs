using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicFireTypeLv1 : MonoBehaviour
{
    public enum FireType
    {
        T1,
        T2,
        T3
    }
    public FireType type;
    public EnemyInfo enemyInfo;
    private GameObject _bullet;
    private float _timeToShoot;
    public Transform canon;



    // Start is called before the first frame update
    void Start()
    {
        _bullet = enemyInfo.bullet;
        _timeToShoot = enemyInfo.fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        ActionOfFire();
    }

    public void ActionOfFire()
    {
        _timeToShoot -= Time.deltaTime;
        if( _timeToShoot < 0)
        {
            if (type == FireType.T1)
            {
                Instantiate(_bullet,canon.position,canon.rotation * Quaternion.Euler(0f, 0f, 90f));
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, 180f));
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, 270f));
            }

            if (type == FireType.T2)
            {
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, 45f));
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, -45f));
                

            }

            if (type == FireType.T3)
            {
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, 60f));
                Instantiate(_bullet, canon.position, canon.rotation * Quaternion.Euler(0f, 0f, -60f));
            }

            _timeToShoot = enemyInfo.fireRate;
        }
        
    }
}
