using UnityEngine;

public class SpawnLvEnenmys : MonoBehaviour
{
    [SerializeField]
    private float timeUntilBoss;    
    private float roundTIme;
    public GameObject boss;    
    public GameObject[] enemys,astTypes;   
    public Transform[] points;
    public Transform  astRandomPoint;
    [SerializeField]
    private float timer,currentTimer;
    // Start is called before the first frame update
    void Start()
    {
        roundTIme = 200f;        
        timeUntilBoss = roundTIme;
        boss.SetActive(false);
        currentTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        
        SpawnEnemys();
        BossInComing();


    }

    public void SpawnEnemys()
    {
        
        currentTimer -= Time.deltaTime;
        if(currentTimer <= 0f)
        {
            int x = Random.Range(0,enemys.Length);
            int y = Random.Range(0,points.Length);
            int z = Random.Range(0, astTypes.Length);
            Instantiate(enemys[x], points[y].position, points[y].rotation);
            Instantiate(astTypes[z],astRandomPoint.position,astRandomPoint.rotation);
            currentTimer = timer;
        }

    }

    public void BossInComing()
    {
        timeUntilBoss -= Time.deltaTime;
        if(timeUntilBoss <= 0f) {

            boss.SetActive(true);
            Destroy(gameObject,.2f);
        }
    }


   

    
}
