using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_conteroller : MonoBehaviour
{
    int _speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keyboard_movement();
    }
    private void keyboard_movement()
    {
        float xp = transform.position.x;
        float yp = transform.position.y;
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalinput);
        transform.Translate(Vector3.up * Time.deltaTime * _speed * verticalinput);
        if (xp < 5.0f && xp > -5.0f && yp < 5.0f && yp > -5.0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalinput);
            transform.Translate(Vector3.up * Time.deltaTime * _speed * verticalinput);
        }
        else if (xp > 9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, -10);
        }
        else if (xp < -9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, -10);
        }
        if (yp > 5.0f)
        {
            transform.position = new Vector3(transform.position.x, 5.0f, -10);
        }
        else if (yp < -5.0f)
        {
            transform.position = new Vector3(transform.position.x, -5.0f, -10);
        }
    }
}
