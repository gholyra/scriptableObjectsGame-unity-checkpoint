using System.Collections;
using UnityEngine;

public class RandomWeaponSpawn : MonoBehaviour
{

    [SerializeField] private WeaponObjectSO weaponsToBeInstantiated;

    private void Start()
    {
        StartCoroutine(SpawnWeapon());
    }

    private IEnumerator SpawnWeapon()
    {
        while (true)
        {
            float randomXPos = Random.Range(-9f, 9f);
            Transform weapon = weaponsToBeInstantiated.prefab;
            Instantiate(weapon, new Vector3(randomXPos, 6f), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
