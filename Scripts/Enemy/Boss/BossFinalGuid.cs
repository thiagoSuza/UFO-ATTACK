using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFinalGuid : MonoBehaviour
{
    public GameObject bulletGuided;
    public Transform tgt = null;
    public float sensorRange;
    public LayerMask layerMask;
    public Rigidbody2D theRB;
    public Transform canon;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Action", 9f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] target = Physics2D.OverlapCircleAll(transform.position, sensorRange, layerMask);
        if (target.Length > 0 )
        {
            tgt = target[0].transform;
            
        }

        Seek();
    }

    public void Seek()
    {
        if (tgt != null)
        {
            
            Vector3 lookDirection = tgt.position - transform.position;
            float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            theRB.rotation = lookAngle;
        }
        
    }

    public void Action()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(bulletGuided,canon.position,canon.rotation * Quaternion.Euler(0f, 0f, 90f));
            yield return new WaitForSeconds(2f);
        }

        yield return new WaitForSeconds(1f);
    }
}
