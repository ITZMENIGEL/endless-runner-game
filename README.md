# Endless Runner Game - Complete Unity Project

## 🎮 Ready to Play!

This is a fully functional Subway Surfers-style endless runner game built with Unity. Everything is configured and ready to go!

## ✨ Features

✅ **Endless Gameplay** - Infinite procedurally generated levels  
✅ **Three-Lane Movement** - Swipe left/right to navigate  
✅ **Dynamic Obstacles** - Avoid various obstacles  
✅ **Coin Collection** - Collect coins for points  
✅ **Power-ups** - Shield yourself from obstacles  
✅ **Score System** - Track your distance and coins  
✅ **Smooth Controls** - Responsive player movement  
✅ **Jump & Slide** - Dodge obstacles with skill  

## 🕹️ Controls

| Action | Key |
|--------|-----|
| Move Left | `A` or `Left Arrow` |
| Move Right | `D` or `Right Arrow` |
| Jump | `Space` |
| Slide | `Left Control` |

## 🚀 Quick Start

1. **Open in Unity** (2021 LTS or higher)
2. **Open the Main Scene**: `Assets/Scenes/Main.unity`
3. **Press Play** - The game is ready to run!

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── Player/
│   │   └── PlayerController.cs        # Player movement & controls
│   ├── Level/
│   │   └── LevelGenerator.cs          # Procedural level generation
│   ├── Obstacles/
│   │   └── Obstacle.cs                # Obstacle behavior
│   ├── Collectibles/
│   │   ├── Coin.cs                    # Coin behavior
│   │   └── PowerUp.cs                 # Power-up behavior
│   ├── Managers/
│   │   └── GameManager.cs             # Game state management
│   └── UI/
│       └── UIManager.cs               # UI management
├── Prefabs/
│   ├── Player.prefab
│   ├── Ground.prefab
│   ├── Obstacle.prefab
│   ├── Coin.prefab
│   └── PowerUp.prefab
├── Scenes/
│   └── Main.unity                     # Main game scene
└── README.md
```

## 🎯 Gameplay Tips

- **Collect coins** to increase your score
- **Use the slide** to go under obstacles
- **Jump over obstacles** to avoid them
- **Get power-ups** for shield protection
- **Stay on the track** to survive longer

## 📊 Game Mechanics

### Scoring
- Base score increases with distance traveled
- +10 points per coin collected
- +25 points for destroying obstacles while sliding

### Movement
- Smooth lane-based movement (3 lanes)
- Physics-based jumping
- Slide mechanic to avoid obstacles

### Obstacles
- Random spawn patterns
- Can be destroyed by sliding
- Game ends on collision (without shield)

### Power-ups
- Shield protection (1 hit)
- Rare spawns
- Visual indicator when active

## 🛠️ Customization

You can easily tweak game parameters in the Inspector:

**PlayerController:**
- `moveSpeed` - Forward movement speed
- `laneWidth` - Distance between lanes
- `jumpForce` - Jump height

**LevelGenerator:**
- `obstacleSpawnRate` - How often obstacles appear
- `coinSpawnRate` - How often coins appear
- `powerUpSpawnRate` - How often power-ups appear

## 📝 License

MIT License - Free to use and modify!

## 🎓 Learning Resources

This project demonstrates:
- GameObject prefabs and instantiation
- Physics-based player movement
- Procedural level generation
- Singleton pattern (GameManager)
- UI with TextMesh Pro
- Collision and trigger detection
- Scene management

Have fun playing and modifying! 🚀
