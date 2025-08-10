# ML Agents Basic Unity Package

This Unity package provides basic ML-Agents functionality for learning purposes.

## Components

### BasicAgent
Base class for ML agents with basic episode management and reward handling.

### ExampleAgent  
Example implementation that demonstrates:
- Random movement actions
- Boundary checking
- Reward/penalty system
- Episode management

## Usage

1. Add this package to your Unity project
2. Create a GameObject with a Rigidbody component
3. Attach the ExampleAgent script
4. Configure the agent settings in the inspector
5. Run the scene to see the agent in action

## Integration with Python Training

Use the configuration files in the `config/` directory with the ML-Agents Python package for training:

```bash
mlagents-learn config/ppo/Basic.yaml --run-id=YourRunID
```

This package provides the Unity side components needed for ML-Agents training.