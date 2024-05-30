using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameUIManager : MonoBehaviour
{
   GameObject countText;

    void Start()
    {
      countText = GameObject.Find("Count");
   }

   // Update is called once per frame
   void Update()
    {
      GameManager.time += Time.deltaTime;
      countText.GetComponent<TextMeshProUGUI>().text = GameManager.time.ToString("F0");      
   }
}
