using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Bow : MonoBehaviour
{

    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;
    public Text numArrows;

    private void Start()
    {
        launchForce = 12;
    }

    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - bowPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0))
        {
            if(Int32.Parse(numArrows.text) > 0)
            {
                Shoot();
                int numberOfArrows = Int32.Parse(numArrows.text) - 1;
                numArrows.text = numberOfArrows.ToString();
            }
        }

        void Shoot()
        {
            GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        }
    }
}
