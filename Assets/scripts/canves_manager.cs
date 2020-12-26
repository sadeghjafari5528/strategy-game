using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canves_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;
    public void goToTownMap()
    {
        SceneManager.LoadScene("town_map");
    }
    public void go_north()
    {
        camera.transform.Translate(Vector3.up * Time.deltaTime * 5);
    }
}
