using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prejuizo : MonoBehaviour
{
    private UIManager _uiManager;
    [SerializeField]
    private float _Speed = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _Speed);

        if (transform.position.y < -5.0f)
        {
            transform.position = new Vector3(Random.Range(7f, -7f), 5.0f, transform.position.z);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _uiManager.UpdateNegativePoints();
            Destroy(this.gameObject);
           
        }
    }
}
