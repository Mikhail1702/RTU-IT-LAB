
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class CountDownTime : MonoBehaviour{
 public string LevelToLoad;
 private float timer = 30f;
 public TextMeshProUGUI timerSeconds;


 // Use this for initialization
 void Start () 
 {
  
 }
 
 // Update is called once per frame
 void Update () 
 {
  timer -= Time.deltaTime;
  
  timerSeconds.text = timer.ToString("f0");
  if (timer <= 0) 
  {
   Application.LoadLevel(LevelToLoad);
  }

 }
}

