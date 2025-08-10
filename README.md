# First Try ML-Agents

A minimal Unity ML-Agents setup for getting started with machine learning in Unity.

## Overview

This repository contains a basic implementation of Unity ML-Agents framework components:

- Python training environment setup
- Basic training configuration
- Minimal Unity C# agent implementation
- Simple training script

## Getting Started

### Prerequisites

- Python 3.8+
- Unity 2022.3+ (for Unity components)

### Installation

1. Install Python dependencies:
```bash
pip install -r requirements.txt
```

2. Configure training parameters in `config/ppo/Basic.yaml`

3. Run training:
```bash
python train.py
```

## Structure

- `requirements.txt` - Python dependencies
- `config/` - Training configuration files
- `train.py` - Basic training script
- `com.unity.ml-agents-basic/` - Minimal Unity package with agent scripts

This is a simplified version of the full Unity ML-Agents framework for learning purposes.