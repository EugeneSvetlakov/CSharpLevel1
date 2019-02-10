namespace lev1les7t1
{
    partial class WF_Udvoitel
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResultTxt = new System.Windows.Forms.Label();
            this.lblShagCountTxt = new System.Windows.Forms.Label();
            this.lblShagCountNum = new System.Windows.Forms.Label();
            this.lblCeil = new System.Windows.Forms.Label();
            this.lblCeilNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMinStep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(106, 49);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(23, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "-1";
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Location = new System.Drawing.Point(18, 131);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(112, 35);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnX2
            // 
            this.btnX2.Enabled = false;
            this.btnX2.Location = new System.Drawing.Point(17, 175);
            this.btnX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(112, 35);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            this.btnX2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(207, 175);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // lblResultTxt
            // 
            this.lblResultTxt.AutoSize = true;
            this.lblResultTxt.Location = new System.Drawing.Point(13, 49);
            this.lblResultTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultTxt.Name = "lblResultTxt";
            this.lblResultTxt.Size = new System.Drawing.Size(91, 20);
            this.lblResultTxt.TabIndex = 2;
            this.lblResultTxt.Text = "Рузультат:";
            // 
            // lblShagCountTxt
            // 
            this.lblShagCountTxt.AutoSize = true;
            this.lblShagCountTxt.Location = new System.Drawing.Point(41, 85);
            this.lblShagCountTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShagCountTxt.Name = "lblShagCountTxt";
            this.lblShagCountTxt.Size = new System.Drawing.Size(63, 20);
            this.lblShagCountTxt.TabIndex = 2;
            this.lblShagCountTxt.Text = "Ход №:";
            // 
            // lblShagCountNum
            // 
            this.lblShagCountNum.AutoSize = true;
            this.lblShagCountNum.Location = new System.Drawing.Point(106, 85);
            this.lblShagCountNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShagCountNum.Name = "lblShagCountNum";
            this.lblShagCountNum.Size = new System.Drawing.Size(23, 20);
            this.lblShagCountNum.TabIndex = 0;
            this.lblShagCountNum.Text = "-1";
            // 
            // lblCeil
            // 
            this.lblCeil.AutoSize = true;
            this.lblCeil.Location = new System.Drawing.Point(156, 49);
            this.lblCeil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeil.Name = "lblCeil";
            this.lblCeil.Size = new System.Drawing.Size(138, 20);
            this.lblCeil.TabIndex = 2;
            this.lblCeil.Text = "Заданное число:";
            // 
            // lblCeilNum
            // 
            this.lblCeilNum.AutoSize = true;
            this.lblCeilNum.Location = new System.Drawing.Point(296, 49);
            this.lblCeilNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilNum.Name = "lblCeilNum";
            this.lblCeilNum.Size = new System.Drawing.Size(23, 20);
            this.lblCeilNum.TabIndex = 0;
            this.lblCeilNum.Text = "-1";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(207, 131);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Шаг назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(338, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameSubMenuItem});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(46, 19);
            this.MenuItem1.Text = "Игра";
            // 
            // NewGameSubMenuItem
            // 
            this.NewGameSubMenuItem.Name = "NewGameSubMenuItem";
            this.NewGameSubMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewGameSubMenuItem.Text = "Новая игра";
            this.NewGameSubMenuItem.Click += new System.EventHandler(this.NewGameSubMenuItem_Click);
            // 
            // lblMinStep
            // 
            this.lblMinStep.AutoSize = true;
            this.lblMinStep.Location = new System.Drawing.Point(296, 85);
            this.lblMinStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinStep.Name = "lblMinStep";
            this.lblMinStep.Size = new System.Drawing.Size(23, 20);
            this.lblMinStep.TabIndex = 0;
            this.lblMinStep.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Осталось ходов:";
            // 
            // WF_Udvoitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCeil);
            this.Controls.Add(this.lblShagCountTxt);
            this.Controls.Add(this.lblResultTxt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.lblMinStep);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblCeilNum);
            this.Controls.Add(this.lblShagCountNum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 276);
            this.MinimumSize = new System.Drawing.Size(354, 276);
            this.Name = "WF_Udvoitel";
            this.Text = "Удвоитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResultTxt;
        private System.Windows.Forms.Label lblShagCountTxt;
        private System.Windows.Forms.Label lblShagCountNum;
        private System.Windows.Forms.Label lblCeil;
        private System.Windows.Forms.Label lblCeilNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewGameSubMenuItem;
        private System.Windows.Forms.Label lblMinStep;
        private System.Windows.Forms.Label label2;
    }
}

