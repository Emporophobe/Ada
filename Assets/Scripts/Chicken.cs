using UnityEngine;

namespace Assets.Scripts
{
    public class Chicken : AbstractBehavior
    {
        public Rigidbody2D target;

        // Use this for initialization
        protected override void Start()
        {
            base.Start();
            Health = 100;
            Speed = 5;
        }

        protected override Vector2 GetDirection()
        {
            return target != null
                ? target.position - GetComponent<Rigidbody2D>().position
                : Vector2.zero;
        }
    }
}
