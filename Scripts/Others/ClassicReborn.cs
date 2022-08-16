using UnityEngine;

public class ClassicReborn : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,0f,15f * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FightersGameController.instace.isTwoPlayer == true) 
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (PlayerTwoLife.instance.gameOver == true)
                {
                    PlayerTwoLife.instance.Reborn();
                }
                Destroy(gameObject);
            }
            else if (collision.gameObject.CompareTag("Player2"))
            {
                if (PlayerOneLife.instance.gameOver == true)
                {
                    PlayerOneLife.instance.Reborn();
                }
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
