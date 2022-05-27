namespace WinAppMazeGame
{
    partial class frmAutomaticBeginnerMazeRightRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutomaticBeginnerMazeRightRule));
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
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
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(16, 295);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(100, 22);
            this.txtDirection.TabIndex = 34;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 223);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 52);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(16, 164);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(120, 52);
            this.btnSolve.TabIndex = 32;
            this.btnSolve.Text = "Resolver";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(16, 326);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 22);
            this.txtData.TabIndex = 31;
            // 
            // picWalker
            // 
            this.picWalker.Image = global::WinAppMazeGame.Properties.Resources.raton;
            this.picWalker.Location = new System.Drawing.Point(382, 36);
            this.picWalker.Margin = new System.Windows.Forms.Padding(4);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(33, 31);
            this.picWalker.TabIndex = 3;
            this.picWalker.TabStop = false;
            // 
            // picCheese
            // 
            this.picCheese.Image = global::WinAppMazeGame.Properties.Resources.ima_queso;
            this.picCheese.Location = new System.Drawing.Point(799, 324);
            this.picCheese.Margin = new System.Windows.Forms.Padding(4);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(100, 92);
            this.picCheese.TabIndex = 2;
            this.picCheese.TabStop = false;
            // 
            // picMaze
            // 
            this.picMaze.Image = global::WinAppMazeGame.Properties.Resources.laberinto_principianteXS1;
            this.picMaze.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMaze.InitialImage")));
            this.picMaze.Location = new System.Drawing.Point(157, 15);
            this.picMaze.Margin = new System.Windows.Forms.Padding(4);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(633, 585);
            this.picMaze.TabIndex = 1;
            this.picMaze.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Image = global::WinAppMazeGame.Properties.Resources.raton_perez;
            this.picMouse.Location = new System.Drawing.Point(16, 15);
            this.picMouse.Margin = new System.Windows.Forms.Padding(4);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(100, 129);
            this.picMouse.TabIndex = 0;
            this.picMouse.TabStop = false;
            // 
            // frmAutomaticBeginnerMazeRightRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 614);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.picMouse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAutomaticBeginnerMazeRightRule";
            this.Text = "Laberinto Nivel Principiante (Regla de la Mano Derecha)";
            this.Load += new System.EventHandler(this.frmAutomaticBeginnerMaze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtData;
    }
}