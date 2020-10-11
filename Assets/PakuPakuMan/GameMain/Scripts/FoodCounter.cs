using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class FoodCounter : MonoBehaviour
    {
        [SerializeField]
        SceneController sceneController;
        int FoodCount = 0;
        // Start is called before the first frame update
        void Start()
        {
            GameObject[] foods = GameObject.FindGameObjectsWithTag("Food");
            FoodCount = foods.Length;
        }

        // Update is called once per frame
        void Update()
        {
            if(FoodCount <= 0)
            {
                sceneController.TransitionResult();
            }
        }

        public void FoodDest()
        {
            FoodCount--;
        }
    }
}