﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui
{
    class CreditWindow : Window
    {
        private Button backButton;

        private TextBlock creditTextBlock;

        public CreditWindow() : base(28, 10, 60, 18, '#')
        {
            List<String> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Unknown");
            creditData.Add("");
            creditData.Add("Creator:");
            creditData.Add("Eye");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Unknown");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Unknown");
            creditData.Add("");

            creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);


            backButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            backButton.SetActive();
        }

        public void Render()
        {
            base.Render();
            creditTextBlock.Render();
            backButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}