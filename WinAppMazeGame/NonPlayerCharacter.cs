using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.Threading;

namespace WinAppMazeGame
{
    class NonPlayerCharacter
    {
        public enum Direction
        {
            Up,   // 0 (Field)
            Down, // 1 (Field)
            Left, // 2 (Field)
            Right // 3 (Field)
        }
        protected int[,] mMatrix;
        protected int mRow, mColumn;
        protected int mM, mN;
        protected Direction mDirection;
        protected int mMiliseconds;

        public NonPlayerCharacter()
        {
            mRow = 0; 
            mColumn = 0;
            mM = 0; mN = 0;
            mMiliseconds = 100;
        }

        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    if (mMatrix[i, j] == 2)
                    {
                        // mRow = 1; mColumn = 8;
                        mRow = i; mColumn = j;
                        return;
                    }
                }
            }
        }

        public void MoveRightSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left + 25;
            mColumn++;
        }

        public void MoveLeftSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left - 25;
            mColumn--;
        }

        public void MoveUpSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top - 25;
            mRow--;
        }

        public void MoveDownSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top + 25;
            mRow++;
        }

        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }
        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    mMatrix[i, j] = a[i, j];
                }
            }
        }

        public bool DetermineFinishDirection(PictureBox picWalker)
        {
            if (mMatrix[mRow, mColumn + 1] == 3)
            {
                mDirection = Direction.Right;
                MoveRightSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow, mColumn - 1] == 3)
            {
                mDirection = Direction.Left;
                MoveLeftSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow - 1, mColumn] == 3)
            {
                mDirection = Direction.Up;
                MoveUpSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow + 1, mColumn] == 3)
            {
                mDirection = Direction.Down;
                MoveDownSide(picWalker);
                return true;
            }
            else
                return false;
        }

        public void DetermineStartDirection()
        {
            // 2, 1 (Primer 1 ha estado ubicado a la Derecha)
            if (mMatrix[mRow, mColumn + 1] != 0)
            {
                mDirection = Direction.Right;
            }
            else if (mMatrix[mRow, mColumn - 1] != 0)
            {
                mDirection = Direction.Left;
            }
            else if (mMatrix[mRow - 1, mColumn] != 0)
            {
                mDirection = Direction.Up;
            }
            else if (mMatrix[mRow + 1, mColumn] != 0)
            {
                mDirection = Direction.Down;
            }
        }


        public bool ObserveRightSide()
        {
            return mMatrix[mRow, mColumn + 1] == 1;
        }

        public bool ObserveLeftSide()
        {
            return mMatrix[mRow, mColumn - 1] == 1;
        }

        public bool ObserveUpSide()
        {
            return mMatrix[mRow - 1, mColumn] == 1;
        }

        public bool ObserveDownSide()
        {
            return mMatrix[mRow + 1, mColumn] == 1;
        }
    }
}
