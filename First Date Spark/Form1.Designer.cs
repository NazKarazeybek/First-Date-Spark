namespace First_Date_Spark
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.aceButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.walkerButton = new System.Windows.Forms.Button();
            this.haelButton = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.supriseButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.playButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(657, 466);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(194, 54);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.SandyBrown;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(433, 470);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(431, 61);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue..";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // aceButton
            // 
            this.aceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(118)))), ((int)(((byte)(83)))));
            this.aceButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.aceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aceButton.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(18)))));
            this.aceButton.Location = new System.Drawing.Point(71, 455);
            this.aceButton.Name = "aceButton";
            this.aceButton.Size = new System.Drawing.Size(149, 44);
            this.aceButton.TabIndex = 3;
            this.aceButton.Text = "Ace";
            this.aceButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aceButton.UseVisualStyleBackColor = false;
            this.aceButton.Click += new System.EventHandler(this.aceButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(0, -2);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(864, 188);
            this.textLabel.TabIndex = 4;
            // 
            // textLabel2
            // 
            this.textLabel2.BackColor = System.Drawing.Color.Transparent;
            this.textLabel2.Font = new System.Drawing.Font("Edwardian Script ITC", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.textLabel2.Location = new System.Drawing.Point(2, 323);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(862, 108);
            this.textLabel2.TabIndex = 5;
            this.textLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // walkerButton
            // 
            this.walkerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(118)))), ((int)(((byte)(83)))));
            this.walkerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.walkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.walkerButton.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(18)))));
            this.walkerButton.Location = new System.Drawing.Point(374, 455);
            this.walkerButton.Name = "walkerButton";
            this.walkerButton.Size = new System.Drawing.Size(149, 44);
            this.walkerButton.TabIndex = 6;
            this.walkerButton.Text = "Walker";
            this.walkerButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.walkerButton.UseVisualStyleBackColor = false;
            this.walkerButton.Click += new System.EventHandler(this.walkerButton_Click);
            // 
            // haelButton
            // 
            this.haelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(118)))), ((int)(((byte)(83)))));
            this.haelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.haelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.haelButton.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(18)))));
            this.haelButton.Location = new System.Drawing.Point(657, 455);
            this.haelButton.Name = "haelButton";
            this.haelButton.Size = new System.Drawing.Size(149, 44);
            this.haelButton.TabIndex = 7;
            this.haelButton.Text = "Hael";
            this.haelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.haelButton.UseVisualStyleBackColor = false;
            this.haelButton.Click += new System.EventHandler(this.haelButton_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Tan;
            this.option1Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option1Button.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(18)))));
            this.option1Button.Location = new System.Drawing.Point(-4, 466);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(431, 69);
            this.option1Button.TabIndex = 8;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Tan;
            this.option2Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option2Button.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(18)))));
            this.option2Button.Location = new System.Drawing.Point(433, 466);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(431, 69);
            this.option2Button.TabIndex = 9;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // supriseButton
            // 
            this.supriseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(136)))), ((int)(((byte)(120)))));
            this.supriseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.supriseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supriseButton.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supriseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(44)))), ((int)(((byte)(39)))));
            this.supriseButton.Location = new System.Drawing.Point(220, 466);
            this.supriseButton.Name = "supriseButton";
            this.supriseButton.Size = new System.Drawing.Size(431, 69);
            this.supriseButton.TabIndex = 10;
            this.supriseButton.Text = "Suprise Me!";
            this.supriseButton.UseVisualStyleBackColor = false;
            this.supriseButton.Click += new System.EventHandler(this.supriseButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(100)))), ((int)(((byte)(84)))));
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(211)))), ((int)(((byte)(191)))));
            this.restartButton.Location = new System.Drawing.Point(220, 466);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(431, 69);
            this.restartButton.TabIndex = 11;
            this.restartButton.Text = "Play Again?";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 532);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.supriseButton);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.haelButton);
            this.Controls.Add(this.walkerButton);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.aceButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "First Date Spark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button aceButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Button walkerButton;
        private System.Windows.Forms.Button haelButton;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button supriseButton;
        private System.Windows.Forms.Button restartButton;
    }
}

