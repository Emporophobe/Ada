using UnityEngine;

namespace Assets.Scripts
{
    public abstract class AbstractBehavior : MonoBehaviour
    {
        /// <summary>
        /// The health of the entity. When health is 0 or less, the entity dies.
        /// </summary>
        protected float Health;
        /// <summary>
        /// The speed of the entity, in units per frame.
        /// </summary>
        protected float Speed;
        /// <summary>   
        /// The direction the entity will move.
        /// </summary>
        protected Vector2 Direction;

        // Use this for initialization
        protected virtual void Start ()
        {
            GetComponent<Rigidbody2D>().gravityScale = 0; // ignore gravity
            GetComponent<Rigidbody2D>().freezeRotation = true;
            Speed = 0;
            Direction = Vector2.zero;
        }
	
        // Update is called once per frame
        protected virtual void Update ()
        {
            if (Health <= 0)
            {
                Die();
                return;
            }
            Direction = GetDirection();
            GetComponent<Rigidbody2D>().velocity = (Direction.magnitude > 1 ? Direction.normalized : Direction) * Speed;
        }

        protected virtual Vector2 GetDirection()
        {
            return Vector2.zero;
        }

        protected virtual void Die()
        {
            Speed = 0;
            Destroy(this);
        }
    }
}
