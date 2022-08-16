using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{   
    void Start()
    {
        Destroy(gameObject, .9f);
    }    
}
