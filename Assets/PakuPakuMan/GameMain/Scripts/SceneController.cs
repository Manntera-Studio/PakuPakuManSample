using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameMain
{
    public class SceneController : MonoBehaviour
    {
        public void TransitionResult(GameData.ResultKind result)
        {
            GameData.Result = result;
            SceneManager.LoadScene("Result");
        }
    }
}