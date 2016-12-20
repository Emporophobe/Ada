using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : AbstractBehavior
    {
        protected override void Start()
        {
            base.Start();
            Health = 100;
            Speed = 5;
        }
        protected override Vector2 GetDirection()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector2(horizontal, vertical);
        }
    }
}
