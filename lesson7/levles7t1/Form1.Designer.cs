namespace levles7t1
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
            this.btnGame = new System.Windows.Forms.Button();
            this.lblResultTxt = new System.Windows.Forms.Label();
            this.lblShagCountTxt = new System.Windows.Forms.Label();
            this.lblShagCountNum = new System.Windows.Forms.Label();
            this.lblCeil = new System.Windows.Forms.Label();
            this.lblCeilNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(79, 54);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "-1";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(139, 44);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(139, 73);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(75, 23);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            this.btnX2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(139, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(139, 15);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(75, 23);
            this.btnGame.TabIndex = 1;
            this.btnGame.Text = "Играть";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            this.btnGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // lblResultTxt
            // 
            this.lblResultTxt.AutoSize = true;
            this.lblResultTxt.Location = new System.Drawing.Point(15, 54);
            this.lblResultTxt.Name = "lblResultTxt";
            this.lblResultTxt.Size = new System.Drawing.Size(58, 13);
            this.lblResultTxt.TabIndex = 2;
            this.lblResultTxt.Text = "Рузультат";
            // 
            // lblShagCountTxt
            // 
            this.lblShagCountTxt.AutoSize = true;
            this.lblShagCountTxt.Location = new System.Drawing.Point(32, 83);
            this.lblShagCountTxt.Name = "lblShagCountTxt";
            this.lblShagCountTxt.Size = new System.Drawing.Size(41, 13);
            this.lblShagCountTxt.TabIndex = 2;
            this.lblShagCountTxt.Text = "Шаг №";
            // 
            // lblShagCountNum
            // 
            this.lblShagCountNum.AutoSize = true;
            this.lblShagCountNum.Location = new System.Drawing.Point(79, 83);
            this.lblShagCountNum.Name = "lblShagCountNum";
            this.lblShagCountNum.Size = new System.Drawing.Size(16, 13);
            this.lblShagCountNum.TabIndex = 0;
            this.lblShagCountNum.Text = "-1";
            // 
            // lblCeil
            // 
            this.lblCeil.AutoSize = true;
            this.lblCeil.Location = new System.Drawing.Point(32, 102);
            this.lblCeil.Name = "lblCeil";
            this.lblCeil.Size = new System.Drawing.Size(36, 13);
            this.lblCeil.TabIndex = 2;
            this.lblCeil.Text = "Цель:";
            // 
            // lblCeilNum
            // 
            this.lblCeilNum.AutoSize = true;
            this.lblCeilNum.Location = new System.Drawing.Point(79, 102);
            this.lblCeilNum.Name = "lblCeilNum";
            this.lblCeilNum.Size = new System.Drawing.Size(16, 13);
            this.lblCeilNum.TabIndex = 0;
            this.lblCeilNum.Text = "-1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(139, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Шаг назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // WF_Udvoitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 180);
            this.Controls.Add(this.lblCeil);
            this.Controls.Add(this.lblShagCountTxt);
            this.Controls.Add(this.lblResultTxt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblCeilNum);
            this.Controls.Add(this.lblShagCountNum);
            this.Controls.Add(this.lblResult);
            this.Name = "WF_Udvoitel";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblResultTxt;
        private System.Windows.Forms.Label lblShagCountTxt;
        private System.Windows.Forms.Label lblShagCountNum;
        private System.Windows.Forms.Label lblCeil;
        private System.Windows.Forms.Label lblCeilNum;
        private System.Windows.Forms.Button btnBack;
    }
}

