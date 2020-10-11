
using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameMain
{
    public class ScoreViewer : MonoBehaviour
    {
        [SerializeField] private Text scoreText;

        private void Update()
        {
            scoreText.text = "Score:" + GameData.Score;
        }
    }
}