namespace QuizPlatform
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
            this.Login = new System.Windows.Forms.Label();
            this.Username1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(330, 114);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(101, 38);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Username1
            // 
            this.Username1.AutoSize = true;
            this.Username1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Username1.Location = new System.Drawing.Point(300, 169);
            this.Username1.Name = "Username1";
            this.Username1.Size = new System.Drawing.Size(65, 15);
            this.Username1.TabIndex = 1;
            this.Username1.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(303, 187);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(158, 20);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Password1.Location = new System.Drawing.Point(300, 220);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(61, 15);
            this.Password1.TabIndex = 3;
            this.Password1.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(303, 238);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(158, 20);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Submit.Location = new System.Drawing.Point(337, 282);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(94, 38);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Login";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Username1);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Username1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Submit;
    }
}

