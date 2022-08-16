using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwo : MonoBehaviour
{
    public static PlayerTwo instance;
    private float speed = 5f;
    public Text missilAmountTxt, especialAmountTxt;
    [SerializeField]
    private GameObject _bullet, _especial;
    [SerializeField]
    private GameObject missil;
    private int missilAcount, especialAcount;
    public Transform canon1, missilAndEspecialPoint;
    public GameObject _shootEffec;
    public GameObject[] especials;
    public ClassicWeaponControllerTwo cwctwo;
    public AudioSource[] audios;
    private int audioIdex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {

        _bullet = cwctwo.bulletInUse;
        missilAcount = 5;
        missilAmountTxt.text = missilAcount.ToString();
        especialAcount = 3;
        especialAmountTxt.text = especialAcount.ToString();



    }

    // Update is called once per frame
    void Update()
    {
        _bullet = cwctwo.bulletInUse;
        _shootEffec = cwctwo.shootEffectInUse;
        Movement();
        Fire();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }


    public void Fire()
    {
        //Canon
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.yellow && cwctwo.blvcounter == 3)
            {
                YeellowFourLvBullet();
            }
            else
            {
                Instantiate(_bullet, canon1.position, canon1.rotation);
                Instantiate(_shootEffec, canon1.position, canon1.rotation);
                audios[audioIdex].Play();
            }

        }

        //Missil
        if (Input.GetKeyDown(KeyCode.N))
        {
            if(missilAcount > 0)
            {
                Instantiate(missil, missilAndEspecialPoint.position, missilAndEspecialPoint.rotation);
                missilAcount--;
                missilAmountTxt.text = missilAcount.ToString();
                OthersAudio.instance.MissilSound();
            }
           
        }

        //Especial
        if (Input.GetKeyDown(KeyCode.M))
        {

            if (especialAcount > 0)
            {
                EspecialManager();

                especialAcount--;
                especialAmountTxt.text = especialAcount.ToString();
                OthersAudio.instance.SpecialSound();

            }
        }
    }


    public void MissilUp()
    {
        missilAcount++;
        missilAmountTxt.text = missilAcount.ToString();
    }

    public void EspecialUp()
    {
        especialAcount++;
        especialAmountTxt.text = especialAcount.ToString();
    }

    public void EspecialManager()
    {
        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.red)
        {
            GameObject resEsp = Instantiate(especials[4], transform.position, transform.rotation);
            resEsp.transform.SetParent(canon1.transform.parent);
        }

        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.yellow)
        {
            Instantiate(especials[3], canon1.position, canon1.rotation);
        }

        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.purple)
        {
            Instantiate(especials[1], canon1.position, canon1.rotation);
        }

        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.blue)
        {
            GameObject blueEsp = Instantiate(especials[2], canon1.position, canon1.rotation);
            blueEsp.transform.SetParent(canon1.transform.parent);
        }

        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.normal)
        {
            StartCoroutine("SpecialNormal");
        }
    }

    IEnumerator SpecialNormal()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(especials[0], missilAndEspecialPoint.position, missilAndEspecialPoint.rotation);
            yield return new WaitForSeconds(1f);
        }


    }

    public void YeellowFourLvBullet()
    {
        Instantiate(_bullet, canon1.position, canon1.rotation);
        Instantiate(_bullet, canon1.position, canon1.rotation * Quaternion.Euler(0f, 0f, 30f));
        Instantiate(_bullet, canon1.position, canon1.rotation * Quaternion.Euler(0f, 0f, -30f));
        Instantiate(_bullet, canon1.position, canon1.rotation * Quaternion.Euler(0f, 0f, 70f));
        Instantiate(_bullet, canon1.position, canon1.rotation * Quaternion.Euler(0f, 0f, -70f));
        Instantiate(_shootEffec, canon1.position, canon1.rotation);
    }

    public float SpeedUp(float increse)
    {
        speed += increse;
        return speed;
    }

    public float SpeedDown(float decresce)
    {
        speed -= decresce;
        return speed;
    }

    public void SomVerify()
    {
        if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.blue)
        {
            audioIdex = 1;
        }
        else if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.red)
        {
            audioIdex = 2;
        }
        else if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.purple)
        {
            audioIdex = 3;
        }
        else if (cwctwo.crystalInUseTwo == CrystalClassic.ClassicCrystalType.yellow)
        {
            audioIdex = 4;
        }

    }
}
