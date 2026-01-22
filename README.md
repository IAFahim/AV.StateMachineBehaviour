# AV.StateMachineBehaviour

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)
[![Version](https://img.shields.io/badge/Version-1.0.0-orange.svg)](CHANGELOG.md)

StateMachineBehaviour helpers for Unity with caching and combat system integration.

## Features

- StateMachineBehaviourPlayerCombatComponent for combat state handling
- Component caching with AV.Unity.Extend integration
- Tag-based state filtering
- Automatic cache cleanup on scene changes
- Optimized for combat systems using Animator

## Installation

```
Window > Package Manager > + > Add package from git URL
```
```
https://github.com/IAFahim/AV.StateMachineBehaviour.git
```

## Usage

```csharp
using AV.StateMachineBehaviour.Runtime;

// Add StateMachineBehaviourPlayerCombatComponent to your Animator state
// Configure tag in Inspector (default: "Attack")
// Will call AttackFinished() on PlayerCombatComponent when state exits
```

## License

MIT License - see [LICENSE.md](LICENSE.md) for details.

## Author

**IAFahim** - [GitHub](https://github.com/IAFahim)
