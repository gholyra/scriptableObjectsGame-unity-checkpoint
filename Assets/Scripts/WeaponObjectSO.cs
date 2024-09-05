using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableAssets/New Weapon")]
public class WeaponObjectSO : ScriptableObject
{

    public Transform prefab;
    public int damagePoints = 1;
    
    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnHitPlayer();
        }
    }

    private void OnHitPlayer()
    {
        PlayerBehaviour.Instance.OnDamage(damagePoints);
    }
    
}
