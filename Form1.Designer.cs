namespace RockScissorsPaper_Game
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
            this.rockButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userChoiceTextBox = new System.Windows.Forms.TextBox();
            this.computerChoiceTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.DarkCyan;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rockButton.ForeColor = System.Drawing.Color.LightCyan;
            this.rockButton.Location = new System.Drawing.Point(26, 12);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(130, 45);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "rock";
            this.rockButton.UseVisualStyleBackColor = false;
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackColor = System.Drawing.Color.DarkCyan;
            this.scissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissorsButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scissorsButton.ForeColor = System.Drawing.Color.LightCyan;
            this.scissorsButton.Location = new System.Drawing.Point(184, 12);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(130, 45);
            this.scissorsButton.TabIndex = 1;
            this.scissorsButton.Text = "scissors";
            this.scissorsButton.UseVisualStyleBackColor = false;
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.DarkCyan;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paperButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperButton.ForeColor = System.Drawing.Color.LightCyan;
            this.paperButton.Location = new System.Drawing.Point(347, 12);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(130, 45);
            this.paperButton.TabIndex = 2;
            this.paperButton.Text = "paper";
            this.paperButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player\'s choice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choosing a computer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(20, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // userChoiceTextBox
            // 
            this.userChoiceTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.userChoiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userChoiceTextBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userChoiceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.userChoiceTextBox.Location = new System.Drawing.Point(340, 91);
            this.userChoiceTextBox.Name = "userChoiceTextBox";
            this.userChoiceTextBox.Size = new System.Drawing.Size(145, 32);
            this.userChoiceTextBox.TabIndex = 6;
            // 
            // computerChoiceTextBox
            // 
            this.computerChoiceTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.computerChoiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerChoiceTextBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerChoiceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.computerChoiceTextBox.Location = new System.Drawing.Point(340, 151);
            this.computerChoiceTextBox.Name = "computerChoiceTextBox";
            this.computerChoiceTextBox.Size = new System.Drawing.Size(145, 32);
            this.computerChoiceTextBox.TabIndex = 7;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.resultTextBox.Location = new System.Drawing.Point(340, 208);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(145, 32);
            this.resultTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(514, 279);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.computerChoiceTextBox);
            this.Controls.Add(this.userChoiceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.rockButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Rock - Scissors - Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userChoiceTextBox;
        private System.Windows.Forms.TextBox computerChoiceTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

