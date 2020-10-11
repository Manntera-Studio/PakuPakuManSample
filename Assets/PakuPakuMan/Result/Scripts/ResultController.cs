using System;
using UnityEngine;
using UnityEngine.UI;

namespace Result
{
    public class ResultController : MonoBehaviour
    {
        [SerializeField] private Text mainText;
        [SerializeField] private Text scoreText;

        public void DisplayResult(GameData.ResultKind resultKind, int score)
        {
            switch (resultKind)
            {
                case GameData.ResultKind.Clear:
                    mainText.text = "やったー";
                    break;
                case GameData.ResultKind.GameOver:
                    mainText.text = "ぴえん";
                    break;
                case GameData.ResultKind.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(resultKind), resultKind, null);
            }

            scoreText.text = "Score:" + score;
        }
    }
}