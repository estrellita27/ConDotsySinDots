using UnityEngine;

namespace SML.Dots
{
    public class Alien : MonoBehaviour
    {
        public Vector3 Direction;
        private float timer = 80000f;
        private const float destructionTime = 100000f; // Time after which the entity is destroyed

        private bool destructionEnabled = false; // Flag to control when destruction starts

        public void Update()
        {
            // Check if destruction is enabled
            if (destructionEnabled)
            {
                // Update timer and destroy if destruction time is reached
                timer += Time.deltaTime;
                if (timer >= destructionTime)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                // Check if it's time to enable destruction
                if (timer >= 5f)
                {
                    destructionEnabled = true;
                }

                // Keep updating timer
                timer += Time.deltaTime;
            }

            // Randomly destroy some aliens
            if (Random.value < 0.003f)
            {
                Destroy(gameObject);
            }

            transform.localPosition += Direction * Time.deltaTime* 30f;
        }
    }
}
