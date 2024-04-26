using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleNavigation : MonoBehaviour
{

    public static SimpleNavigation instance {get; private set;}

    // private void Awake() 
    // { 
    //     // If there is an instance, and it's not me, delete myself.
        
    //     if (instance != null && instance != this) 
    //     { 
    //         Destroy(this); 
    //     } 
    //     else 
    //     { 
    //         instance = this; 
    //     } 
    // }

    public void loadScene(string name) {
        // Debug.Log("asfdaf");
        SceneManager.LoadScene(name);
    }

    public void asyncLoadScene(string name) {
        StartCoroutine(customAsyncLoad(name));
    }
    IEnumerator customAsyncLoad(string name)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void endApp() {
        Application.Quit();
    }

}
