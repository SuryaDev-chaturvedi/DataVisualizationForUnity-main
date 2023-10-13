using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscene : MonoBehaviour
{
   public void nextscene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
