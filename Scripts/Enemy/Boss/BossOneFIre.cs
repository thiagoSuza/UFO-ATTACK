using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOneFIre : MonoBehaviour
{
    public GameObject _bullet, _missil, _laser;
    public Transform c1, c2;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ActionOfFire", 6f, 55f);
        anim.SetBool("ok", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActionOfFire()
    {
        StartCoroutine("Fire");
    }


    IEnumerator Fire()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(_bullet, transform.position,transform.rotation * Quaternion.Euler(0f, 0f, 30f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -30f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 45f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -45f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 60f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -60f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 75f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -75f));
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(3f);

        for(int i = 0; i < 6; i++)
        {
            Instantiate(_missil, c1.position, c1.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(_missil, c2.position, c2.rotation);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 30f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -30f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 45f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -45f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 60f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -60f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 75f));
            Instantiate(_bullet, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -75f));
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(3f);

        for (int i = 0; i < 6; i++)
        {
            Instantiate(_laser, c1.position, c1.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(_laser, c2.position, c2.rotation);
            yield return new WaitForSeconds(1f);
        }
    }
}
