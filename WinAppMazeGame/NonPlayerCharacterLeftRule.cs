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
    class NonPlayerCharacterLeftRule: NonPlayerCharacter
    {
        public void InitializePausedMovement(TextBox txtDirection, PictureBox picWalker)
        {
            DetermineStartDirection();
            switch (mDirection)
            {
                case Direction.Down:
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Up:
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Right:
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Left:
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
            }
        }
        public void PausedMovementWithAI(TextBox txtDirection, PictureBox picWalker)
        {
            if (mDirection == Direction.Right)
            {
                this.RightCases(txtDirection, picWalker);
                Thread.Sleep(mMiliseconds);
            }
            if (mDirection == Direction.Left)
            {
                this.LeftCases(txtDirection, picWalker);
                Thread.Sleep(mMiliseconds);
            }

            if (mDirection == Direction.Up)
            {
                this.UpCases(txtDirection, picWalker);
                Thread.Sleep(mMiliseconds);
            }

            if (mDirection == Direction.Down)
            {
                this.DownCases(txtDirection, picWalker);
                Thread.Sleep(mMiliseconds);
            }
        }

        public void RightCases(TextBox txtDirection, PictureBox picWalker)
        {
            if ((!ObserveUpSide() && !ObserveDownSide() && ObserveRightSide()) ||
                (!ObserveUpSide() && ObserveDownSide() && ObserveRightSide()))
            {
                mDirection = Direction.Right;
                txtDirection.Text = mDirection.ToString();
                MoveRightSide(picWalker);
            }
            else if (ObserveUpSide())
            {
                mDirection = Direction.Up;
                txtDirection.Text = mDirection.ToString();
                MoveUpSide(picWalker);
            }
            else if (!ObserveUpSide() && !ObserveRightSide() && ObserveDownSide())
            {
                mDirection = Direction.Down;
                txtDirection.Text = mDirection.ToString();
                MoveDownSide(picWalker);
            }
            else if (!ObserveUpSide() && !ObserveRightSide() && !ObserveDownSide())
            {
                mDirection = Direction.Left;
                txtDirection.Text = mDirection.ToString();
                MoveLeftSide(picWalker);
            }
        }
        public void LeftCases(TextBox txtDirection, PictureBox picWalker)
        {
            if ((!ObserveUpSide() && !ObserveDownSide() && ObserveLeftSide()) ||
                (ObserveUpSide() && !ObserveDownSide() && ObserveLeftSide()))
            {
                mDirection = Direction.Left;
                txtDirection.Text = mDirection.ToString();
                MoveLeftSide(picWalker);
            }
            else if (ObserveDownSide())
            {
                mDirection = Direction.Down;
                txtDirection.Text = mDirection.ToString();
                MoveDownSide(picWalker);
            }
            else if (ObserveUpSide() && !ObserveDownSide() && !ObserveLeftSide())
            {
                mDirection = Direction.Up;
                txtDirection.Text = mDirection.ToString();
                MoveUpSide(picWalker);
            }
            else if (!ObserveUpSide() && !ObserveDownSide() && !ObserveLeftSide())
            {
                mDirection = Direction.Right;
                txtDirection.Text = mDirection.ToString();
                MoveRightSide(picWalker);
            }
        }
        public void UpCases(TextBox txtDirection, PictureBox picWalker)
        {
            if ((!ObserveLeftSide() && !ObserveRightSide() && ObserveUpSide()) ||
                (!ObserveLeftSide() && ObserveRightSide() && ObserveUpSide()))
            {
                mDirection = Direction.Up;
                txtDirection.Text = mDirection.ToString();
                MoveUpSide(picWalker);
            }
            else if (ObserveLeftSide())
            {
                mDirection = Direction.Left;
                txtDirection.Text = mDirection.ToString();
                MoveLeftSide(picWalker);
            }
            else if (!ObserveLeftSide() && ObserveRightSide() && !ObserveUpSide())
            {
                mDirection = Direction.Right;
                txtDirection.Text = mDirection.ToString();
                MoveRightSide(picWalker);
            }
            else if (!ObserveLeftSide() && !ObserveRightSide() && !ObserveUpSide())
            {
                mDirection = Direction.Down;
                txtDirection.Text = mDirection.ToString();
                MoveDownSide(picWalker);
            }
        }
        public void DownCases(TextBox txtDirection, PictureBox picWalker)
        {
            if ((!ObserveLeftSide() && !ObserveRightSide() && ObserveDownSide()) ||
                (ObserveLeftSide() && !ObserveRightSide() && ObserveDownSide()))
            {
                mDirection = Direction.Down;
                txtDirection.Text = mDirection.ToString();
                MoveDownSide(picWalker);
            }
            else if (ObserveLeftSide() && !ObserveRightSide() && !ObserveDownSide())
            {
                mDirection = Direction.Left;
                txtDirection.Text = mDirection.ToString();
                MoveLeftSide(picWalker);
            }
            else if (ObserveRightSide())
            {
                mDirection = Direction.Right;
                txtDirection.Text = mDirection.ToString();
                MoveRightSide(picWalker);
            }
            else if (!ObserveLeftSide() && !ObserveRightSide() && !ObserveDownSide())
            {
                mDirection = Direction.Up;
                txtDirection.Text = mDirection.ToString();
                MoveUpSide(picWalker);
            }
        }
    }
}
