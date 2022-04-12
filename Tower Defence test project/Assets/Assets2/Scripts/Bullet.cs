using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed, Damage;

    void Start()
    {
        if(gameObject!=null)
        Destroy(gameObject, 2);
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
