using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _zoomSpeed = 2f;
    [SerializeField] private float _minZoom = 2f;
    [SerializeField] private float _maxZoom = 10f;

    private Camera cam;
    private void Awake()
    {
            this.cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement =new  Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * _movementSpeed * Time.deltaTime;
    }
}
