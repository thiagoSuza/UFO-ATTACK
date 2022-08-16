using UnityEngine;

public class Refill : MonoBehaviour
{
   public enum RefillType
    {
        missil,
        especial,
        health,
        life
    }
    
    private float randomNumber;
    public RefillType type;

    public void ActionRefill1()
    {
        if(type == RefillType.missil)
        {
            PlayerOne.instance.MissilUp();
        }
        else if(type == RefillType.especial)
        {
            PlayerOne.instance.EspecialUp();
        }
        else if (type == RefillType.health)
        {
            PlayerOneLife.instance.UpHealth();
        }
        else if (type == RefillType.life)
        {
            PlayerOneLife.instance.UpLife();    
        }
    }

    public void ActionRefill2()
    {
        if (type == RefillType.missil)
        {
            PlayerTwo.instance.MissilUp();
        }
        else if (type == RefillType.especial)
        {
            PlayerTwo.instance.EspecialUp();
        }
        else if (type == RefillType.health)
        {
            PlayerTwoLife.instance.UpHealth();
        }
        else if (type == RefillType.life)
        {
            PlayerTwoLife.instance.UpLife();
        }
    }

    private void Start()
    {
        randomNumber = Random.Range(-30, 30);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, randomNumber) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OthersAudio.instance.PickUpSound();
        if (collision.gameObject.CompareTag("Player"))
        {
            ActionRefill1();
           
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            ActionRefill2();
            
            Destroy(gameObject);
        }
        
    }

}
