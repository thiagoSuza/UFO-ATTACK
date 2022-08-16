using System.Collections;
using UnityEngine;

public class BossFourFire : MonoBehaviour
{
    public GameObject bulletOne, bulletTwo,laserShoot;
    public Animator anim;
    public Transform c1, c2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 10f, 13f);
        anim.SetBool("ok", true);
    }

    public void Fire()
    {
        StartCoroutine("F1");
    }

    IEnumerator F1()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(laserShoot, transform.position, transform.rotation);
        yield return new WaitForSeconds(2f);
        Instantiate(laserShoot, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 10; i++)
        {
            Instantiate(bulletOne, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -40f));
            Instantiate(bulletOne, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -20f));
            Instantiate(bulletOne, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, 0f));
            Instantiate(bulletOne, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, 20f));
            Instantiate(bulletOne, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, 40f));
            

            Instantiate(bulletOne, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, -40f));
            Instantiate(bulletOne, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, -20f));
            Instantiate(bulletOne, c2.position, c2.rotation * Quaternion.Euler(0f, 0f,  0f));
            Instantiate(bulletOne, c2.position, c2.rotation * Quaternion.Euler(0f, 0f,  20f));
            Instantiate(bulletOne, c2.position, c2.rotation * Quaternion.Euler(0f, 0f,  40f));
           
        }
        yield return new WaitForSeconds(1f);
        Instantiate(laserShoot, transform.position,transform.rotation);
        yield return new WaitForSeconds(2f);
        Instantiate(laserShoot, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(bulletTwo, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -40f));
            Instantiate(bulletTwo, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -45f));
            Instantiate(bulletTwo, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -50f));

            Instantiate(bulletTwo, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, 50f));
            Instantiate(bulletTwo, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, 45f));
            Instantiate(bulletTwo, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, 40f));
        }

        yield return new WaitForSeconds(1f);
        Instantiate(laserShoot, transform.position, transform.rotation);
        yield return new WaitForSeconds(2f);
        Instantiate(laserShoot, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);

    }
}
