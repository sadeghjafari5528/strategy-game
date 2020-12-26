using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canves_manager : MonoBehaviour
{
    public void goToTownMap()
    {
        Debug.Log("change sence");
        SceneManager.LoadScene("town_map");
    }
}
