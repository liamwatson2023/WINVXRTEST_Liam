using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenLoader : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene("Basic.Flagging");
    }
}
