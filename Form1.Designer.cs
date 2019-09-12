namespace AssaignmentCSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PlayarPB = new System.Windows.Forms.PictureBox();
            this.ComputerPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lblcom = new System.Windows.Forms.Label();
            this.btnrock = new System.Windows.Forms.Button();
            this.btnpaper = new System.Windows.Forms.Button();
            this.btnscissor = new System.Windows.Forms.Button();
            this.txtPlayar = new System.Windows.Forms.TextBox();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.txtCpmputer = new System.Windows.Forms.TextBox();
            this.lblround = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblhuman = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.lbltie = new System.Windows.Forms.Label();
            this.TxtTie = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTImer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayarPB
            // 
            this.PlayarPB.Location = new System.Drawing.Point(21, 49);
            this.PlayarPB.Margin = new System.Windows.Forms.Padding(2);
            this.PlayarPB.Name = "PlayarPB";
            this.PlayarPB.Size = new System.Drawing.Size(124, 209);
            this.PlayarPB.TabIndex = 0;
            this.PlayarPB.TabStop = false;
            this.PlayarPB.Click += new System.EventHandler(this.PlayarPB_Click);
            // 
            // ComputerPB
            // 
            this.ComputerPB.Location = new System.Drawing.Point(190, 49);
            this.ComputerPB.Margin = new System.Windows.Forms.Padding(2);
            this.ComputerPB.Name = "ComputerPB";
            this.ComputerPB.Size = new System.Drawing.Size(131, 209);
            this.ComputerPB.TabIndex = 1;
            this.ComputerPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblplayer.Location = new System.Drawing.Point(18, 19);
            this.lblplayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(47, 16);
            this.lblplayer.TabIndex = 3;
            this.lblplayer.Text = "Player";
            // 
            // lblcom
            // 
            this.lblcom.AutoSize = true;
            this.lblcom.BackColor = System.Drawing.Color.MintCream;
            this.lblcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcom.Location = new System.Drawing.Point(187, 19);
            this.lblcom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcom.Name = "lblcom";
            this.lblcom.Size = new System.Drawing.Size(66, 16);
            this.lblcom.TabIndex = 4;
            this.lblcom.Text = "Computer";
            // 
            // btnrock
            // 
            this.btnrock.BackColor = System.Drawing.Color.White;
            this.btnrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock.Location = new System.Drawing.Point(21, 275);
            this.btnrock.Margin = new System.Windows.Forms.Padding(2);
            this.btnrock.Name = "btnrock";
            this.btnrock.Size = new System.Drawing.Size(98, 30);
            this.btnrock.TabIndex = 5;
            this.btnrock.Text = "Rock";
            this.btnrock.UseVisualStyleBackColor = false;
            this.btnrock.Click += new System.EventHandler(this.btnrock_Click);
            // 
            // btnpaper
            // 
            this.btnpaper.BackColor = System.Drawing.Color.White;
            this.btnpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper.Location = new System.Drawing.Point(21, 316);
            this.btnpaper.Margin = new System.Windows.Forms.Padding(2);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(98, 30);
            this.btnpaper.TabIndex = 6;
            this.btnpaper.Text = "Paper";
            this.btnpaper.UseVisualStyleBackColor = false;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnscissor
            // 
            this.btnscissor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnscissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissor.Location = new System.Drawing.Point(21, 360);
            this.btnscissor.Margin = new System.Windows.Forms.Padding(2);
            this.btnscissor.Name = "btnscissor";
            this.btnscissor.Size = new System.Drawing.Size(98, 30);
            this.btnscissor.TabIndex = 7;
            this.btnscissor.Text = "Scissor";
            this.btnscissor.UseVisualStyleBackColor = false;
            this.btnscissor.Click += new System.EventHandler(this.btnscissor_Click);
            // 
            // txtPlayar
            // 
            this.txtPlayar.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlayar.Location = new System.Drawing.Point(132, 40);
            this.txtPlayar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayar.Name = "txtPlayar";
            this.txtPlayar.Size = new System.Drawing.Size(68, 20);
            this.txtPlayar.TabIndex = 8;
            // 
            // txtWinner
            // 
            this.txtWinner.Location = new System.Drawing.Point(245, 357);
            this.txtWinner.Margin = new System.Windows.Forms.Padding(2);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.ReadOnly = true;
            this.txtWinner.Size = new System.Drawing.Size(101, 20);
            this.txtWinner.TabIndex = 9;
            this.txtWinner.TextChanged += new System.EventHandler(this.tbroud_TextChanged);
            // 
            // txtCpmputer
            // 
            this.txtCpmputer.Location = new System.Drawing.Point(132, 94);
            this.txtCpmputer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpmputer.Name = "txtCpmputer";
            this.txtCpmputer.ReadOnly = true;
            this.txtCpmputer.Size = new System.Drawing.Size(68, 20);
            this.txtCpmputer.TabIndex = 10;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblround.Location = new System.Drawing.Point(151, 355);
            this.lblround.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(65, 20);
            this.lblround.TabIndex = 11;
            this.lblround.Text = "Winner";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(50, 101);
            this.lblComputer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(52, 13);
            this.lblComputer.TabIndex = 12;
            this.lblComputer.Text = "Computer";
            // 
            // lblhuman
            // 
            this.lblhuman.AutoSize = true;
            this.lblhuman.Location = new System.Drawing.Point(50, 47);
            this.lblhuman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhuman.Name = "lblhuman";
            this.lblhuman.Size = new System.Drawing.Size(36, 13);
            this.lblhuman.TabIndex = 13;
            this.lblhuman.Text = "Playar";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(541, 358);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Count";
            // 
            // TxtCount
            // 
            this.TxtCount.BackColor = System.Drawing.Color.MintCream;
            this.TxtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCount.Location = new System.Drawing.Point(245, 295);
            this.TxtCount.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.ReadOnly = true;
            this.TxtCount.Size = new System.Drawing.Size(68, 26);
            this.TxtCount.TabIndex = 16;
            // 
            // lbltie
            // 
            this.lbltie.AutoSize = true;
            this.lbltie.Location = new System.Drawing.Point(50, 155);
            this.lbltie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltie.Name = "lbltie";
            this.lbltie.Size = new System.Drawing.Size(22, 13);
            this.lbltie.TabIndex = 18;
            this.lbltie.Text = "Tie";
            // 
            // TxtTie
            // 
            this.TxtTie.Location = new System.Drawing.Point(132, 148);
            this.TxtTie.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTie.Name = "TxtTie";
            this.TxtTie.ReadOnly = true;
            this.TxtTie.Size = new System.Drawing.Size(68, 20);
            this.TxtTie.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCpmputer);
            this.panel1.Controls.Add(this.lbltie);
            this.panel1.Controls.Add(this.txtPlayar);
            this.panel1.Controls.Add(this.TxtTie);
            this.panel1.Controls.Add(this.lblComputer);
            this.panel1.Controls.Add(this.lblhuman);
            this.panel1.Location = new System.Drawing.Point(336, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 209);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Record";
            // 
            // txtTImer
            // 
            this.txtTImer.Location = new System.Drawing.Point(468, 275);
            this.txtTImer.Name = "txtTImer";
            this.txtTImer.ReadOnly = true;
            this.txtTImer.Size = new System.Drawing.Size(68, 20);
            this.txtTImer.TabIndex = 21;
            this.txtTImer.Text = "0";
            this.txtTImer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(419, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Restart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(419, 355);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.Text = "Pause";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(623, 401);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTImer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.btnscissor);
            this.Controls.Add(this.btnpaper);
            this.Controls.Add(this.btnrock);
            this.Controls.Add(this.lblcom);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComputerPB);
            this.Controls.Add(this.PlayarPB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.PlayarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayarPB;
        private System.Windows.Forms.PictureBox ComputerPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblcom;
        private System.Windows.Forms.Button btnrock;
        private System.Windows.Forms.Button btnpaper;
        private System.Windows.Forms.Button btnscissor;
        private System.Windows.Forms.TextBox txtPlayar;
        private System.Windows.Forms.TextBox txtWinner;
        private System.Windows.Forms.TextBox txtCpmputer;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblhuman;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.Label lbltie;
        private System.Windows.Forms.TextBox TxtTie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTImer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
    }
}

