using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    [SerializeField]
    public float transitionTime = 1f;
    // Update is called once per frame
    void Update()
    {
        if(Input. GetMouseButtonDown(0))
        {
        LoadNextLevel();
        }
    }

        public void LoadNextLevel()
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }

        //coroutine
        IEnumerator LoadLevel(int levelIndex)
        {
            //play animation
            transition.SetTrigger ("Start"); 
            //wait 
            yield return new WaitForSeconds(transitionTime);
            //Load scene
            SceneManager.LoadScene(levelIndex);
        }
    
}
