using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    [SerializeField] Transform block;
    [SerializeField] Color color;

    private Transform spawnedBlock;
    private float width = 20;

    void Start()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                spawnedBlock = Instantiate(block, new Vector2(j * 5, i * 5), Quaternion.identity);
                spawnedBlock.SetParent(transform);

                if (i % 2 == 0)
                {
                    if (j % 2 != 0)
                    {
                        spawnedBlock.GetComponent<SpriteRenderer>().color = color;
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        spawnedBlock.GetComponent<SpriteRenderer>().color = color;
                    }
                }
            }
        }
    }
}
