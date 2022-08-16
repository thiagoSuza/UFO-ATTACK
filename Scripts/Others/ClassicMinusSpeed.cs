using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicMinusSpeed : MonoBehaviour
{
    private float lessSpeed = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerOne.instance.SpeedDown(lessSpeed);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            PlayerTwo.instance.SpeedDown(lessSpeed);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
