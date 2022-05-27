namespace WinAppMazeGame
{
    partial class frmManualBeginnerMaze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtData = new System.Windows.Forms.TextBox();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(16, 151);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(99, 22);
            this.txtData.TabIndex = 8;
            // 
            // picWalker
            // 
            this.picWalker.Image = global::WinAppMazeGame.Properties.Resources.raton;
            this.picWalker.Location = new System.Drawing.Point(158, 66);
            this.picWalker.Margin = new System.Windows.Forms.Padding(4);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(25, 25);
            this.picWalker.TabIndex = 7;
            this.picWalker.TabStop = false;
            // 
            // picCheese
            // 
            this.picCheese.Image = global::WinAppMazeGame.Properties.Resources.ima_queso;
            this.picCheese.Location = new System.Drawing.Point(772, 324);
            this.picCheese.Margin = new System.Windows.Forms.Padding(4);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(100, 92);
            this.picCheese.TabIndex = 6;
            this.picCheese.TabStop = false;
            // 
            // picMaze
            // 
            this.picMaze.Image = global::WinAppMazeGame.Properties.Resources.simple_maze;
            this.picMaze.Location = new System.Drawing.Point(131, 15);
            this.picMaze.Margin = new System.Windows.Forms.Padding(4);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(633, 585);
            this.picMaze.TabIndex = 5;
            this.picMaze.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Image = global::WinAppMazeGame.Properties.Resources.raton_perez;
            this.picMouse.Location = new System.Drawing.Point(16, 15);
            this.picMouse.Margin = new System.Windows.Forms.Padding(4);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(100, 129);
            this.picMouse.TabIndex = 4;
            this.picMouse.TabStop = false;
            // 
            // frmManualBeginnerMaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 615);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.picMouse);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManualBeginnerMaze";
            this.Text = "frmManualBeginnerMaze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManualBeginnerMaze_FormClosed);
            this.Load += new System.EventHandler(this.frmManualBeginnerMaze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManualBeginnerMaze_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.TextBox txtData;
    }
}