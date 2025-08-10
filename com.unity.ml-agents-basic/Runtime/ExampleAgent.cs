using UnityEngine;

namespace MLAgentsBasic
{
    /// <summary>
    /// Example agent that demonstrates basic ML-Agents concepts.
    /// This agent moves randomly and receives rewards based on staying within bounds.
    /// </summary>
    public class ExampleAgent : BasicAgent
    {
        [Header("Example Agent Settings")]
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float boundarySize = 10f;
        
        private Rigidbody rb;
        private Vector3 startingPosition;
        
        public override void Start()
        {
            rb = GetComponent<Rigidbody>();
            startingPosition = transform.position;
            base.Start();
        }
        
        public override void OnEpisodeBegin()
        {
            // Reset position to starting point
            transform.position = startingPosition;
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
            
            base.OnEpisodeBegin();
        }
        
        public override void OnActionReceived(float[] actions)
        {
            // In a full ML-Agents setup, actions would come from the neural network
            // For this example, we'll use random actions
            Vector3 movement = new Vector3(actions[0], 0, actions[1]);
            
            if (rb != null)
            {
                rb.AddForce(movement * moveSpeed);
            }
            
            // Check boundaries and give rewards/penalties
            CheckBoundaries();
        }
        
        /// <summary>
        /// Simulate random actions for demonstration
        /// </summary>
        public void PerformRandomAction()
        {
            float[] randomActions = new float[]
            {
                Random.Range(-1f, 1f), // X movement
                Random.Range(-1f, 1f)  // Z movement
            };
            
            OnActionReceived(randomActions);
        }
        
        private void CheckBoundaries()
        {
            Vector3 pos = transform.position;
            
            // Give small positive reward for staying in bounds
            if (Mathf.Abs(pos.x) < boundarySize && Mathf.Abs(pos.z) < boundarySize)
            {
                AddReward(0.01f);
            }
            else
            {
                // Penalty for going out of bounds
                AddReward(-1f);
                EndEpisode();
            }
        }
        
        public override void FixedUpdate()
        {
            // Perform random actions for demonstration
            PerformRandomAction();
            
            base.FixedUpdate();
        }
    }
}