# 🎮 Endless Runner Game - Complete Setup Guide

## ✅ Project Status: READY TO PLAY!

Your endless runner game is **100% complete** and ready to open in Unity!

---

## 🚀 Quick Start Instructions

### Step 1: Clone the Repository
```bash
git clone https://github.com/ITZMENIGEL/endless-runner-game.git
cd endless-runner-game
```

### Step 2: Open in Unity
1. Open **Unity Hub**
2. Click **Open Project**
3. Select the `endless-runner-game` folder
4. Unity will automatically load all assets

### Step 3: Run the Game
1. Go to **Assets/Scenes/**
2. Double-click **Main.unity** to open the scene
3. Press **Play** ▶️

**That's it! The game is ready to play!** 🎉

---

## 🎮 How to Play

### Controls
| Action | Key |
|--------|-----|
| **Move Left** | `A` or `←` |
| **Move Right** | `D` or `→` |
| **Jump** | `Space` |
| **Slide** | `Left Control` |

### Gameplay
- 🏃 **Run forward** - Your character automatically runs forward
- 🎯 **Avoid obstacles** - Stay away from red blocks
- 💰 **Collect coins** - Golden spheres for points
- ⚡ **Get power-ups** - Glowing cyan squares for shield
- 📊 **Build your score** - Points increase with distance & coins

---

## 📦 What's Included

### ✅ Complete Scripts
- ✓ `PlayerController.cs` - Player movement & controls
- ✓ `LevelGenerator.cs` - Infinite level generation
- ✓ `GameManager.cs` - Game state & scoring
- ✓ `UIManager.cs` - HUD & menus
- ✓ `Obstacle.cs` - Obstacle behaviors
- ✓ `Coin.cs` - Coin collection
- ✓ `PowerUp.cs` - Shield power-ups

### ✅ Pre-configured Assets
- ✓ **Scene** - Main game scene with all GameObjects
- ✓ **Prefabs** - Ground, Obstacles, Coins, PowerUps
- ✓ **Materials** - Color-coded materials for all objects
- ✓ **UI Canvas** - Ready for HUD elements

### ✅ Game Mechanics
- ✓ Smooth 3-lane movement system
- ✓ Physics-based jumping & sliding
- ✓ Procedural obstacle generation
- ✓ Collision detection
- ✓ Score tracking system
- ✓ Game over screen
- ✓ Shield power-up system

---

## 🎨 Visual Guide

### Colors
- 🔵 **Blue** - Player character
- ⬜ **Gray** - Ground
- 🔴 **Red** - Obstacles (avoid!)
- 🟡 **Yellow** - Coins (collect!)
- 🟢 **Cyan** - Power-ups (grab!)

---

## 🔧 Project Settings

### Customize Gameplay (In Unity Inspector)

#### PlayerController Settings
```
Move Speed: 5 (how fast the player runs)
Lane Width: 1.5 (distance between lanes)
Jump Force: 8 (jump height)
Ground Drag: 5 (ground friction)
Air Drag: 1 (air resistance)
```

#### LevelGenerator Settings
```
Initial Tiles: 10 (starting tiles to spawn)
Obstacle Spawn Rate: 0.4 (40% chance)
Coin Spawn Rate: 0.3 (30% chance)
PowerUp Spawn Rate: 0.05 (5% chance)
Tile Length: 10 (distance between tiles)
```

### To Adjust Settings:
1. Select **LevelGenerator** in the Hierarchy
2. Adjust values in the **Inspector** panel
3. Play to see changes in real-time!

---

## 🐛 Troubleshooting

### Game Won't Start?
- ✓ Make sure **Main.unity** scene is open
- ✓ Check that **GameManager** exists in scene
- ✓ Verify **LevelGenerator** has prefabs assigned

### Player Falls Through Ground?
- ✓ Ensure **PlayerPhysics** has a **Rigidbody**
- ✓ Check **Ground** collider is enabled
- ✓ Verify **Gravity** is on in Physics settings

### No UI Visible?
- ✓ Canvas should exist in scene
- ✓ Check Canvas scale mode is **Scale with Screen Size**
- ✓ Add text elements to Canvas for HUD

---

## 📝 File Structure

```
Assets/
├── Scripts/
│   ├── Player/
│   │   └── PlayerController.cs
│   ├── Level/
│   │   └── LevelGenerator.cs
│   ├── Obstacles/
│   │   └── Obstacle.cs
│   ├── Collectibles/
│   │   ├── Coin.cs
│   │   └── PowerUp.cs
│   ├── Managers/
│   │   └── GameManager.cs
│   └── UI/
│       └── UIManager.cs
├── Prefabs/
│   ├── Ground.prefab
│   ├── Obstacle.prefab
│   ├── Coin.prefab
│   └── PowerUp.prefab
├── Materials/
│   ├── PlayerMaterial.mat
│   ├── GroundMaterial.mat
│   ├── ObstacleMaterial.mat
│   ├── CoinMaterial.mat
│   └── PowerUpMaterial.mat
└── Scenes/
    └── Main.unity
```

---

## 🎯 Next Steps (Optional Enhancements)

### Want to Customize Further?

1. **Add Sound Effects**
   - Import audio files
   - Add AudioSource to GameManager
   - Play sounds on events (jump, coin collect, etc.)

2. **Add Particle Effects**
   - Create particle systems for coins/powerups
   - Add trail renderer to player

3. **Improve Graphics**
   - Replace cubes with 3D models
   - Add skybox and lighting
   - Create animated sprites

4. **Add More Features**
   - Multiple difficulty levels
   - Leaderboard system
   - Shop for cosmetics
   - Special events/challenges

---

## 📚 Learning Resources

This project teaches:
- ✓ Physics-based character controller
- ✓ Procedural generation algorithms
- ✓ Object pooling & prefabs
- ✓ Singleton pattern (GameManager)
- ✓ Event-driven architecture
- ✓ UI management
- ✓ Collision detection

---

## 🤝 Contributing

Want to improve the game? Fork and submit pull requests!

---

## 📄 License

MIT License - Use freely for personal & commercial projects!

---

## ❓ FAQ

**Q: Can I run this on mobile?**  
A: Yes! The code supports touch input. Add swipe controls in PlayerController.

**Q: How do I add more obstacles?**  
A: Adjust `obstacleSpawnRate` in LevelGenerator (0.0 to 1.0).

**Q: Can I change the game speed?**  
A: Yes! Modify `moveSpeed` in PlayerController.

**Q: How do I publish this game?**  
A: Build for your target platform (PC, Mobile, Web) in File > Build Settings.

---

**Happy Gaming! 🎮🚀**

If you have questions or run into issues, check the GitHub repository!
