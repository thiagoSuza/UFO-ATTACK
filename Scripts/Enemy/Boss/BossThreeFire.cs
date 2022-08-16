using System.Collections;
using UnityEngine;

public class BossThreeFire : MonoBehaviour
{
    public GameObject bullet, ball;
    public Animator anim;
    public Transform c1, c2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Action", 8.2f, 16f);
        anim.SetBool("ok", true);
    }
    private void Action()
    {
        StartCoroutine("Fire");
    }
    IEnumerator Fire()
    {
        Instantiate(ball, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(bullet, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, -30f));
            Instantiate(bullet, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, 0f));
            Instantiate(bullet, c1.position, c1.rotation * Quaternion.Euler(0f, 0f, 30f));

            Instantiate(bullet, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, -30f));
            Instantiate(bullet, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, 0f));
            Instantiate(bullet, c2.position, c2.rotation * Quaternion.Euler(0f, 0f, 30f));
            yield return new WaitForSeconds(1f);
           

        }
        Instantiate(ball, transform.position, transform.rotation);
        yield return new WaitForSeconds(2f);
        Instantiate(ball, transform.position, transform.rotation);

    }
    

    
}
