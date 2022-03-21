using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void playGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Application.LoadLevel("SampleScene1");
    }
}
