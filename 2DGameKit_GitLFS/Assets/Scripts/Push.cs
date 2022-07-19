using System.Collections;
using System.Collections.Generic;
using Gamekit2D;
using UnityEngine;

public class Push : MonoBehaviour
{

    private Damageable _damageable;

    private EnemyBehaviour _enemyBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        _damageable = GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushObj()
    {
        Debug.Log("Get hit!!");
        GetComponent<Rigidbody2D>().AddForce(_damageable.GetDamageDirection()* 3f, ForceMode2D.Impulse);

        
    }
}
