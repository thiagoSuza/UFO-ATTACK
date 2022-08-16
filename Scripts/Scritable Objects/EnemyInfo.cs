using UnityEngine;

[CreateAssetMenu(fileName = "Enemy 1", menuName = "ScriptableObjects/Enemy Skills")]
public class EnemyInfo : ScriptableObject
{
    public int health;
    public float fireRate;
    public GameObject bullet;
    public GameObject[] refilPack;
    public int scorePoint;
}
