using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameMain
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private List<WallCollider> wallCollider = new List<WallCollider>();
        
        private Rigidbody2D _rigidbody2D;

        private enum FaceDir
        {
            Up,
            Down,
            Left,
            Right,
            None
        }

        private FaceDir GetInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                return FaceDir.Up;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                return FaceDir.Down;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                return FaceDir.Left;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                return FaceDir.Right;
            }

            return FaceDir.None;
        }

        private void ChangeFaceDir()
        {
            var dir = Random.Range(0, 4);
            switch (dir)
            {
                case 0:
                    transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                    break;
                case 1:
                    transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
                    break;
                case 2:
                    transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
                    break;
                case 3:
                    transform.rotation = Quaternion.AngleAxis(-90, Vector3.forward);
                    break;
                case 4:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
            }
        }

        private void MoveFront()
        {
            _rigidbody2D.velocity = transform.up * speed;
        }

        private void Start()
        {
            if (_rigidbody2D == null)
            {
                _rigidbody2D = GetComponent<Rigidbody2D>();
            }

            foreach (var wallCol in wallCollider)
            {
                wallCol.hitEvent.AddListener(ChangeFaceDir);
            }
        }

        private void Update()
        {
            MoveFront();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if((1 << collision.gameObject.layer) == LayerMask.GetMask("Player"))
            {
                SceneController sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
                sceneController.TransitionResult(GameData.ResultKind.GameOver);

            }
        }
    }
}