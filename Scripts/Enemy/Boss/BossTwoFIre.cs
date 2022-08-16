using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTwoFIre : MonoBehaviour
{
    public GameObject _bullet,slash;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ActionOfFIre", 6f, 35f);
        anim.SetBool("ok", true);
    }

    

    public void ActionOfFIre()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        for(int i = 0; i < 18; i++)
        {
            {
                for (int j = -80; j < 100; j+= 15)
                {
                    Instantiate(_bullet,transform.position,transform.rotation * Quaternion.Euler(0f, 0f, j));
                }
                yield return new WaitForSeconds(1f);
            }
        }
        yield return new WaitForSeconds(1f);

        for(int i = 0; i < 6; i++)
        {
            Instantiate(slash, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, -45f));
            yield return new WaitForSeconds(.8f);
            Instantiate(slash, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 45f));
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(1f);
    }
}
