
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Result
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private ResultController resultController;

        private void Start()
        {
            resultController.DisplayResult(GameData.Result, GameData.Score);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameData.ResetResult();
                SceneManager.LoadScene("Title");
            }
        }
    }
}