using UnityEngine;

public class ClassicWeaponController : MonoBehaviour
{
    public CrystalClassic.ClassicCrystalType crystalInUse;
    public CircleCollider2D circleCollider;
    public GameObject[] bullets, shootEffect;
    public GameObject bulletInUse, shootEffectInUse;
    
    
    public int bulletLevel,blvcounter,shootEffectCount;

    // Start is called before the first frame update
    void Start()
    {
        crystalInUse = CrystalClassic.ClassicCrystalType.normal;
        bulletLevel = 0;
        blvcounter = 0;
        shootEffectCount = 3;
        shootEffectInUse = shootEffect[shootEffectCount];
        bulletInUse = bullets[bulletLevel];
        
    }

    // Update is called once per frame
    void Update()
    {
        CrystalVerify();
    }

    public void CrystalVerify()
    {
        bulletInUse = bullets[bulletLevel];
        shootEffectInUse = shootEffect[shootEffectCount];

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("ClassicCrystal"))
        {
            

            if(crystalInUse == collision.gameObject.GetComponent<CrystalClassic>().type)
            {
                if(blvcounter < 3)
                {
                    bulletLevel++;
                    blvcounter++;
                }
                
            }
            else
            {
                crystalInUse = collision.gameObject.GetComponent<CrystalClassic>().type;

                if (collision.gameObject.GetComponent<CrystalClassic>().type == CrystalClassic.ClassicCrystalType.red)
                {
                    bulletLevel = 9;
                    blvcounter = 0;
                    shootEffectCount = 2;
                }

                else if (collision.gameObject.GetComponent<CrystalClassic>().type == CrystalClassic.ClassicCrystalType.blue)
                {
                    bulletLevel = 1;
                    blvcounter = 0;
                    shootEffectCount = 0;
                }

                else if (collision.gameObject.GetComponent<CrystalClassic>().type == CrystalClassic.ClassicCrystalType.yellow)
                {
                    bulletLevel = 13;
                    blvcounter = 0;
                    shootEffectCount = 4;
                }

                else if (collision.gameObject.GetComponent<CrystalClassic>().type == CrystalClassic.ClassicCrystalType.purple)
                {
                    bulletLevel = 5;
                    blvcounter = 0;
                    shootEffectCount = 1;
                }

            }

            

            Destroy(collision.gameObject);
        }
    }
}
