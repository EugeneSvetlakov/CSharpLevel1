namespace lev1les7t2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBgame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMyGuess = new System.Windows.Forms.Button();
            this.LBguess = new System.Windows.Forms.Label();
            this.LBmore = new System.Windows.Forms.Label();
            this.LBless = new System.Windows.Forms.Label();
            this.LBcounter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBgame
            // 
            this.LBgame.AutoSize = true;
            this.LBgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBgame.Location = new System.Drawing.Point(16, 33);
            this.LBgame.Name = "LBgame";
            this.LBgame.Size = new System.Drawing.Size(171, 37);
            this.LBgame.TabIndex = 0;
            this.LBgame.Text = "Ваш ответ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число больше:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartStripMenuItem
            // 
            this.StartStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.StartStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartStripMenuItem.Name = "StartStripMenuItem";
            this.StartStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.StartStripMenuItem.Text = "Начать игру";
            this.StartStripMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Число меньше:";
            // 
            // btnMyGuess
            // 
            this.btnMyGuess.Enabled = false;
            this.btnMyGuess.Location = new System.Drawing.Point(72, 78);
            this.btnMyGuess.Name = "btnMyGuess";
            this.btnMyGuess.Size = new System.Drawing.Size(113, 40);
            this.btnMyGuess.TabIndex = 2;
            this.btnMyGuess.Text = "Введите число";
            this.btnMyGuess.UseVisualStyleBackColor = true;
            this.btnMyGuess.Click += new System.EventHandler(this.btnMyGuess_Click);
            // 
            // LBguess
            // 
            this.LBguess.AutoSize = true;
            this.LBguess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBguess.Location = new System.Drawing.Point(208, 33);
            this.LBguess.Name = "LBguess";
            this.LBguess.Size = new System.Drawing.Size(35, 37);
            this.LBguess.TabIndex = 0;
            this.LBguess.Text = "_";
            // 
            // LBmore
            // 
            this.LBmore.AutoSize = true;
            this.LBmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBmore.Location = new System.Drawing.Point(215, 127);
            this.LBmore.Name = "LBmore";
            this.LBmore.Size = new System.Drawing.Size(24, 26);
            this.LBmore.TabIndex = 0;
            this.LBmore.Text = "1";
            // 
            // LBless
            // 
            this.LBless.AutoSize = true;
            this.LBless.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBless.Location = new System.Drawing.Point(191, 156);
            this.LBless.Name = "LBless";
            this.LBless.Size = new System.Drawing.Size(48, 26);
            this.LBless.TabIndex = 0;
            this.LBless.Text = "100";
            // 
            // LBcounter
            // 
            this.LBcounter.AutoSize = true;
            this.LBcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBcounter.Location = new System.Drawing.Point(215, 185);
            this.LBcounter.Name = "LBcounter";
            this.LBcounter.Size = new System.Drawing.Size(24, 26);
            this.LBcounter.TabIndex = 0;
            this.LBcounter.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ход №";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 220);
            this.Controls.Add(this.btnMyGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBcounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBless);
            this.Controls.Add(this.LBmore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBguess);
            this.Controls.Add(this.LBgame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(285, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 258);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMyGuess;
        private System.Windows.Forms.Label LBguess;
        private System.Windows.Forms.Label LBmore;
        private System.Windows.Forms.Label LBless;
        private System.Windows.Forms.Label LBcounter;
        private System.Windows.Forms.Label label4;
    }
}

