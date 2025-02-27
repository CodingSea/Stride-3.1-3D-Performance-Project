﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenko.Core.Mathematics;
using Xenko.Input;
using Xenko.Engine;
using Xenko.UI;
using Xenko.UI.Controls;

namespace Test03
{
    public class uiScript : SyncScript
    {
        public UIPage page { get; set; }
        public SpawnerScript boxNum;

        private TextBlock fps;
        private TextBlock blocks;
        private DateTime lastTime;
        private float fpsNum;
        private float showNum;
        public override void Start()
        {
            var rootElement = page.RootElement;
            fps = rootElement.FindVisualChildOfType<TextBlock>("FPS Num");
            blocks = rootElement.FindVisualChildOfType<TextBlock>("Blocks Num");
            lastTime = DateTime.Now;
        }

        public override void Update()
        {
            fpsNum++;
            if((DateTime.Now - lastTime) > new TimeSpan(0, 0, 1))
            {
                showNum = fpsNum;
                fpsNum = 0;
                lastTime = DateTime.Now;
            }

            blocks.Text = boxNum.boxesNumbers.ToString();
            
            fps.Text = showNum.ToString();
        }
    }
}
