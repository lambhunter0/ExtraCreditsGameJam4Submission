using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSegmentChecker : MonoBehaviour
{
    public Collider2D segment;
    public int index;
    public int maxIndex;
    private Collider2D plug;
    
    void Start()
    {
        plug = FindObjectOfType<PlugController>().GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col == plug && (maxIndex - index) > 10 )
        {
            Debug.Log("deadboi");
        }
    }
}
