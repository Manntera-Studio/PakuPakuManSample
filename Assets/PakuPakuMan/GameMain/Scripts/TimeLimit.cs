using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameMain
{
    public class TimeLimit : MonoBehaviour
    {
        [SerializeField] float RemainingTime = 1.0f;
        [SerializeField] SceneController sceneController;

        [SerializeField] Text text;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RemainingTime -= Time.deltaTime;
            int timeScond = (int) RemainingTime;
            text.text = "Time:"+timeScond.ToString();
            if (RemainingTime <= 0.0f)
            {
                sceneController.TransitionResult(GameData.ResultKind.GameOver);
            }
        }
    }
}