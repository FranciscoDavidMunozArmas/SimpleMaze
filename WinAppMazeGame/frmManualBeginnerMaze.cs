using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace WinAppMazeGame
{
    public partial class frmManualBeginnerMaze : Form
    {
        private CWalker ObjWalker = new CWalker();
        private int height = 20;
        private int width = 20;
        private int[,] mMatrix = new int[,]
        {
            //Start (2,1)
            //End (18, 18)
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,4,0,1,1,1,0,0,0,0,0,0,0,0},
            {0,2,1,1,1,1,0,1,0,1,0,1,1,0,0,1,1,1,0,0},
            {0,1,0,0,0,1,0,1,0,1,0,0,1,0,1,1,0,1,0,0},
            {0,1,1,1,0,1,0,1,0,1,1,0,1,0,1,0,0,1,0,0},
            {0,1,0,1,0,1,0,1,0,1,0,0,1,0,1,1,0,0,0,0},
            {0,1,0,0,0,1,0,1,0,1,1,0,1,1,1,1,0,1,0,0},
            {0,1,1,1,1,1,0,1,0,0,1,0,0,0,0,1,0,1,1,0},
            {0,0,1,0,1,1,0,1,0,1,1,1,1,0,1,1,1,1,0,0},
            {0,0,1,0,1,0,0,1,0,0,1,0,1,0,0,1,0,1,1,0},
            {0,0,1,0,1,1,0,1,0,0,0,0,1,0,1,1,0,0,1,0},
            {0,0,1,0,0,1,0,1,0,1,1,1,1,0,1,0,0,1,1,0},
            {0,0,1,0,1,1,0,1,0,1,0,0,1,0,1,1,0,0,1,0},
            {0,0,1,0,1,0,0,1,0,1,1,0,1,0,0,1,0,1,1,0},
            {0,0,1,0,1,1,1,1,0,1,0,0,1,0,1,1,1,1,0,0},
            {0,0,1,0,0,1,0,0,0,1,1,0,1,0,1,0,0,0,0,0},
            {0,0,1,0,1,1,1,1,0,0,1,0,1,1,1,1,1,1,0,0},
            {0,0,1,1,1,0,0,1,1,1,1,0,0,0,0,0,1,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,1,3,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };

        private SpeechSynthesizer mSynthesizer = new SpeechSynthesizer();
        private PromptBuilder mPrompt = new PromptBuilder();
        private SpeechRecognitionEngine mRecognition = new SpeechRecognitionEngine();

        public frmManualBeginnerMaze()
        {
            InitializeComponent();
        }

        private void StartSpeech()
        {
            ObjWalker.InitializeGrammar();

            try
            {
                mRecognition.RequestRecognizerUpdate();
                mRecognition.LoadGrammar(ObjWalker.Elements);
                mRecognition.SpeechRecognized += MRecognition_SpeechRecognized; ;
                mRecognition.SetInputToDefaultAudioDevice();
                mRecognition.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void MRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            ObjWalker.ControlSpeechMoves(picWalker, txtData, e);
        }

        private void StopSpeech()
        {
            mRecognition.RecognizeAsyncStop();
        }

        private void frmManualBeginnerMaze_Load(object sender, EventArgs e)
        {
            ObjWalker.CreateMatrix(width, height);
            ObjWalker.InitializeMatrix(mMatrix);
            ObjWalker.InitializeRoad();
            ObjWalker.LocalizeStart();
            // Chat-Bot
            StartSpeech();
        }

        private void frmManualBeginnerMaze_KeyDown(object sender, KeyEventArgs e)
        {
            ObjWalker.ControlMovesInLaberynth(picWalker, e);
        }

        private void frmManualBeginnerMaze_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Chat-Bot
            StopSpeech();
        }
    }
}
