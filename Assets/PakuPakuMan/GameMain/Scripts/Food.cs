using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameMain
{
    public class Food : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Dest();
        }


        private void Dest()
        {
            FoodCounter foodCounter = GameObject.Find("FoodCounter").GetComponent<FoodCounter>();
            foodCounter.FoodDest();
            Destroy(gameObject);
        }
    }
}
