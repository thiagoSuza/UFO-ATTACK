using UnityEngine;

public class ClassicLazerBossOne : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,.2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerOneLife.instance.LoseHealth(_damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            PlayerTwoLife.instance.LoseHealth(_damage);
            Destroy(gameObject);
        }
    }
}
