using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple mouvement du personnage avec ZQSD
public class Movement : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    [SerializeField] private int speed = default;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(horizontal, vertical) * Time.deltaTime * speed);
    }
}
