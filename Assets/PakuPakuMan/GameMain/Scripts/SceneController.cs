using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameMain
{
    public class SceneController : MonoBehaviour
    {
        private void Update()
        {
        }

        public void TransitionResult()
        {
            SceneManager.LoadScene("Result");
        }
    }

}
