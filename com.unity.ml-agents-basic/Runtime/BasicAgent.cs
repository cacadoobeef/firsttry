using UnityEngine;

namespace MLAgentsBasic
{
    /// <summary>
    /// Basic ML Agent implementation for learning purposes.
    /// This is a simplified version of Unity ML-Agents Agent class.
    /// </summary>
    public class BasicAgent : MonoBehaviour
    {
        [Header("Agent Settings")]
        [SerializeField] private string behaviorName = "Basic";
        [SerializeField] private int maxSteps = 1000;
        
        private int currentStep = 0;
        
        public virtual void Start()
        {
            Debug.Log($"BasicAgent '{behaviorName}' started");
            OnEpisodeBegin();
        }
        
        public virtual void FixedUpdate()
        {
            currentStep++;
            
            if (currentStep >= maxSteps)
            {
                EndEpisode();
            }
        }
        
        /// <summary>
        /// Called at the beginning of each episode
        /// </summary>
        public virtual void OnEpisodeBegin()
        {
            currentStep = 0;
            Debug.Log($"Episode began for agent '{behaviorName}'");
        }
        
        /// <summary>
        /// Called when an action is received (in full ML-Agents this would be from training)
        /// </summary>
        /// <param name="actions">Actions to execute</param>
        public virtual void OnActionReceived(float[] actions)
        {
            // Override this method in derived classes to handle actions
        }
        
        /// <summary>
        /// Add reward to the agent
        /// </summary>
        /// <param name="reward">Reward value</param>
        public virtual void AddReward(float reward)
        {
            Debug.Log($"Agent '{behaviorName}' received reward: {reward}");
        }
        
        /// <summary>
        /// End the current episode
        /// </summary>
        public virtual void EndEpisode()
        {
            Debug.Log($"Episode ended for agent '{behaviorName}' after {currentStep} steps");
            OnEpisodeBegin();
        }
    }
}