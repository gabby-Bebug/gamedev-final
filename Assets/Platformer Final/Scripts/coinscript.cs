using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public void Bumped()
    {
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-7, 7f);
        pos.y = Random.Range(-4, 4f);
    }
    
} 
