using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update
  
    void OnButtonClick()
    {
        SceneManager.LoadScene(0);
    }

   
}
