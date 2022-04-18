using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public List<GameObject> screens;

    // Start is called before the first frame update
    void Start()
    {
        this.screens[0].SetActive(true);
    }

    public void UITravel(int screenToActivate)
    {
        for (int i = 0; i < this.screens.Count; i++)
        {
            if (i == screenToActivate)
            {
                this.screens[i].SetActive(true);
            }
            else
            {
                this.screens[i].SetActive(false);
            }
        }
    }

    public void SceneTravel(string sceneToTravel)
    {
        SceneManager.LoadScene(sceneToTravel);
    }


}
