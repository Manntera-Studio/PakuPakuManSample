using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Title
{
    public class SceneController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("GameMain");
            }
        }
    }
}