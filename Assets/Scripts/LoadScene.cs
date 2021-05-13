using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private float sceneCount;
    // Start is called before the first frame update
    void Start()
    {
        sceneCount = SceneManager.sceneCountInBuildSettings;
    }

    // Update is called once per frame
    public void LoadGame(){
        print("test");
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
