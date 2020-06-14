using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_loader : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void scene1()
    {
        SceneManager.LoadScene("Scene!");
    }
    public void scene2()
    {
        SceneManager.LoadScene("secen2");
    }
    public void scene3()
    {
        SceneManager.LoadScene("scene3");
    }
}
