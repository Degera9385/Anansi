using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4.6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput);
        if(transform.position.x >7.0f)
        {
            transform.position = new Vector3(7.0f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -7.0f)
        {
            transform.position = new Vector3(-7.0f, transform.position.y, transform.position.z);
        }
    }
}
