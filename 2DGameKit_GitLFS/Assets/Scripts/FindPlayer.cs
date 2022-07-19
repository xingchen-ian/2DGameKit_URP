using System.Collections;
using System.Collections.Generic;
using Gamekit2D;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public TransitionPoint _transitionPoint;
    // Start is called before the first frame update
    void Start()
    {
        _transitionPoint.transitioningGameObject = GameObject.Find("Ellen");
        _transitionPoint.destinationTransform = _transitionPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
