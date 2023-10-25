using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Transform parent;
    public GameObject monLoot;
    public void monDrop()
    {
        int dropRate = Random.Range(0, 10);
        print(dropRate);

        if (dropRate > 5)
        {
            Instantiate(monLoot, parent.position, parent.rotation);
        }
    }
}
