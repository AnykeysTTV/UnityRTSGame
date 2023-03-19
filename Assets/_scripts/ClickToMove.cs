using System;
using System.Collections;
using UnityEngine;

namespace Assets._scripts
{


    public class ClickToMove : MonoBehaviour
    {
        private Vector3 targetLocation = Vector3.zero;
        private Boolean isMoving = false;
        private float moveSpeed = 2f;

        void Start ()
        {
           Sprite _sprite =  GetComponent<SpriteRenderer>().sprite;

          
        }
        private void setTargetPosition()
        {
            Vector3 mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseLocation.z = transform.position.z;
            targetLocation = mouseLocation;
            isMoving = true;
        }

        private void moveSprite()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetLocation, moveSpeed * Time.deltaTime);

            if(targetLocation == transform.position)
            {
                isMoving = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                setTargetPosition();
            }

            if(isMoving)
            {
                moveSprite();
            }

        }
    }
}