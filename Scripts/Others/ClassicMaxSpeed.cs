using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicMaxSpeed : MonoBehaviour
{
    private float moreSpeed = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerOne.instance.SpeedUp(moreSpeed);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            PlayerTwo.instance.SpeedUp(moreSpeed);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
