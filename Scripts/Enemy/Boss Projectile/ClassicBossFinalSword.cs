using UnityEngine;

public class ClassicBossFinalSword : MonoBehaviour
{
    private int _damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerOneLife.instance.LoseHealth(_damage);
            
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            PlayerTwoLife.instance.LoseHealth(_damage);
            
        }
    }
}
