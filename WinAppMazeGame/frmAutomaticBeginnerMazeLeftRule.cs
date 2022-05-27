using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMazeGame
{
    public partial class frmAutomaticBeginnerMazeLeftRule : Form
    {

        private NonPlayerCharacterLeftRule ObjectNPC = new NonPlayerCharacterLeftRule();
        private int[,] mMatrix = new int[,]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,1,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,0},
{0,1,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0},
{0,1,0,1,0,1,1,1,1,1,1,1,1,0,1,1,1,0,0},
{0,1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,1,0,0},
{0,1,1,1,0,1,1,1,1,1,1,1,1,0,1,0,1,0,0},
{0,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0},
{0,1,0,1,0,1,1,1,1,1,1,1,1,0,1,0,1,0,0},
{0,1,0,1,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0},
{0,1,0,1,0,1,1,1,1,1,1,1,1,0,1,0,1,0,0},
{0,1,1,1,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0},
{0,0,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,0},
{0,1,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,0},
{0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0},
{0,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
{0,1,0,0,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0},
{0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,3,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };
        public frmAutomaticBeginnerMazeLeftRule()
        {
            InitializeComponent();
        }

        private void frmAutomaticBeginnerMazeLeftRule_Load(object sender, EventArgs e)
        {
            ObjectNPC.CreateMatrix(19, 19);
            ObjectNPC.InitializeMatrix(mMatrix);
            ObjectNPC.InitializeRoad();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSolve_Click_1(object sender, EventArgs e)
        {
            ObjectNPC.LocalizeStart();
            ObjectNPC.InitializePausedMovement(txtDirection, picWalker);
            do
            {
                ObjectNPC.PausedMovementWithAI(txtDirection, picWalker);
            } while (!ObjectNPC.DetermineFinishDirection(picWalker));
        }
    }
}
