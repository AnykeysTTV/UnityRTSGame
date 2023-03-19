using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] private bool needUpdate = false;
    private Vector3 _target;
    // Start is called before the first frame update
    void Start()
    {
        _target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown (0) )
        {
            _target = Camera.main.WorldToViewportPoint( Input.mousePosition );
            _target.z = transform.position.z;
            Debug.Log(_target);
            needUpdate = true;
        }

        if (!needUpdate)
            return;

        if(transform.position == _target && needUpdate )
        {
            needUpdate = false;
        }
      

        transform.position=  Vector2.MoveTowards(transform.position, _target, 1f * Time.deltaTime);

        //gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, _mLocation, 1f * Time.deltaTime);
       
    }
}
