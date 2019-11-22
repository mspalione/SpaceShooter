using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed variable of 8
    [SerializeField]
    private float _speed = 8.0f;
    [SerializeField]
    private GameObject _laser;

    // Update is called once per frame
    void Update()
    {
        var y = transform.position.y;
        //translate laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if(y > 8f)
        {
            Destroy(gameObject);
        }
    }
}
