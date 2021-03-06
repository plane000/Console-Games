﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Games {
    class Tetris_Game {
        int width = 29;
        int height = 25;

        bool lost = false;
        bool hault = false;

        public readonly string gridString = "" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█                           █" +
            "█████████████████████████████";

        char[,] grid;
        char[,] oldGrid;


        public void initializeGame() {
            Console.Clear();
            grid = new char[width, height];
            oldGrid = new char[width, height];

            grid = stringToArray(gridString);



            gameLoop();
        }

        private void gameLoop() {
            while (!lost && !hault) {
                oldGrid = getOldGrid(grid);
                List<ConsoleKeyInfo> keys = new List<ConsoleKeyInfo>();
                while (Console.KeyAvailable) {
                    var key = Console.ReadKey(true);
                    keys.Add(key);
                }

                checkRows();

                moveDown();

                keyPressed(keys);

                Thread.Sleep(100);
            }
        }


        private void keyPressed(List<ConsoleKeyInfo> keys) {
            if (keys.Count >= 1) {
                var key = keys[keys.Count - 1];

                switch (key.KeyChar) {
                    case 'Q':
                    case 'q':
                        dispose();
                        hault = true;
                        UserInterface ui = new UserInterface();
                        ui.programStart();
                        break;
                }
            }
        }

        private void checkRows() {

        }

        private void moveDown() {

        }

        private char[,] stringToArray(string toload) {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    grid[j, i] = toload[i * width + j];
                }
            }
            return grid;
        }

        private char[,] getOldGrid(char[,] currentGrid) {
            char[,] oldGrid = new char[width, height];
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    oldGrid[i, j] = currentGrid[i, j];
                }
            }
            return oldGrid;
        }

        public void dispose() {

        }
    }
}
