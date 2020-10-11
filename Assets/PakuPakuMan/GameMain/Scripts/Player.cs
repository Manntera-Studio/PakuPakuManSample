using System;
using UnityEngine;

namespace GameMain
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
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

        private void ChangeFaceDir(FaceDir dir)
        {
            switch (dir)
            {
                case FaceDir.Up:
                    transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                    break;
                case FaceDir.Down:
                    transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
                    break;
                case FaceDir.Left:
                    transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
                    break;
                case FaceDir.Right:
                    transform.rotation = Quaternion.AngleAxis(-90, Vector3.forward) *
                                         Quaternion.AngleAxis(180, Vector3.up);
                    break;
                case FaceDir.None:
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
        }

        private void Update()
        {
            var faceDir = GetInput();
            ChangeFaceDir(faceDir);
            MoveFront();
        }
    }
}