using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Variables
    public GameObject block;
    public int width = 10;
    public int height = 4;
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            float posY = y * block.transform.localScale.y;
            for (int x = 0; x < width; ++x)
            {
                Instantiate(block, new Vector3(x* block.transform.localScale.x, posY, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
