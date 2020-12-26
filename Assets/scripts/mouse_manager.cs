using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class mouse_manager : MonoBehaviour
{
	RaycastHit hit;
	private int raycastLenght = 1000;
	[SerializeField]
	private GameObject town_button;
	Camera c;
	// Start is called before the first frame update
	void Start()
	{
		//Debug.Log(Camera.current.name);
		c = Camera.main;

	}

	// Update is called once per frame
	void Update()
	{
		mouse_movement();
		mouse_handler_click();

	}
	private void mouse_movement()
	{
		float halfHeight = c.orthographicSize;
		float halfWidth = c.aspect * halfHeight;
		//Debug.Log(Input.mousePosition);
		if (Input.mousePosition.x - transform.position.x > halfWidth - 1)
        {
			transform.Translate(Vector3.right * Time.deltaTime * 5);
		}
	}
	private void mouse_handler_click()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray , out hit , raycastLenght))
		{
			if (hit.collider.tag == "town") {

				if (Input.GetMouseButton(0))
				{
					//SceneManager.LoadScene("town_map");
					town_button.SetActive(true);
				}
            }
		}
        else
        {
			if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
			{
				setAllFalse();
			}
        }
	}
	private void setAllFalse()
    {
		town_button.SetActive(false);
	}
}

