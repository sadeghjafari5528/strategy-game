using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
		mouse_handler_click();
	}
	private void mouse_handler_click()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray , out hit , raycastLenght))
		{
			Debug.Log(hit.collider.name);
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

