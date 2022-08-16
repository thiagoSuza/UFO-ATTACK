using UnityEngine;

public class FightersGameController : MonoBehaviour
{
    public GameObject  losePanel;
    public GameObject player2, player2HUD,pressToPlay2;
    public bool isTwoPlayer;
    public GameObject kiaPlayerOne, kiaPlayerTwo;
    public static FightersGameController instace;

    private void Awake()
    {
        instace = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        kiaPlayerOne.SetActive(false);
        kiaPlayerTwo.SetActive(false);
        pressToPlay2.SetActive(true);
        player2HUD.SetActive(false);
        player2.SetActive(false);
        isTwoPlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        TwoPlay();
        Defeat();
    }

    public void TwoPlay()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            pressToPlay2.SetActive(false);
            player2HUD.SetActive(true);
            player2.SetActive(true);
            isTwoPlayer = true;
        }
        
    }

   


    public void Defeat()
    {
        if (!isTwoPlayer)
        {
            if(PlayerOneLife.instance.gameOver == true)
            {
                Time.timeScale = 0f;
                losePanel.SetActive(true);
            }
        }
        else if (isTwoPlayer)
        {
            if(PlayerOneLife.instance.gameOver == true && PlayerTwoLife.instance.gameOver == true)
            {
                Time.timeScale = 0f;
                losePanel.SetActive(true);
            }
        }
        
    }


    
}
