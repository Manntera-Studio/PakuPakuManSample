
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Result
{
    public class SceneController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Title");
            }
        }
    }
}