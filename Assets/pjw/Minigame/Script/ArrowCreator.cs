using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCreator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 2.0f;
    float delta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-3, 4);
            go.transform.position = new Vector3(px, 7, 0);
        }

    }
}
