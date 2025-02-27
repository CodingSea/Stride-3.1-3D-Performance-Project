﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenko.Core.Mathematics;
using Xenko.Input;
using Xenko.Engine;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Physics;

namespace Test03
{
    public class SpawnerScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        public Prefab boxes;

        [DataMemberIgnore]
        public int boxesNumbers = 0;


        private DateTime lastFrame;
        private bool pressed = false;
        public override void Start()
        {
            lastFrame = DateTime.Now;
        }

        public override void Update()
        {
            if (Input.Keyboard.IsKeyPressed(Keys.Space))
            {
                pressed = true;
            }

            if (pressed)
            {
                if ((DateTime.Now - lastFrame) > new TimeSpan(0, 0, 0, 0, 100))
                {
                    boxesNumbers++;
                    var box = boxes.Instantiate();
                    SceneSystem.SceneInstance.RootScene.Entities.AddRange(box);

                    lastFrame = DateTime.Now;
                }
            }

            if (Input.Keyboard.IsKeyDown(Keys.Q))
            {
                pressed = false;
                Game game = new Game();
                game.Exit();
            }
            
        }
    }
}
