
namespace GunesEnerjisi
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
            this.SuButton = new System.Windows.Forms.Button();
            this.SuSicaklikBox = new System.Windows.Forms.TextBox();
            this.EvSicaklikBox = new System.Windows.Forms.TextBox();
            this.EvButton = new System.Windows.Forms.Button();
            this.EvSicaklikGoster = new System.Windows.Forms.TextBox();
            this.SuSicaklikGoster = new System.Windows.Forms.TextBox();
            this.BilgiBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SuButton
            // 
            this.SuButton.Location = new System.Drawing.Point(293, 158);
            this.SuButton.Name = "SuButton";
            this.SuButton.Size = new System.Drawing.Size(75, 29);
            this.SuButton.TabIndex = 0;
            this.SuButton.Text = "Su";
            this.SuButton.UseVisualStyleBackColor = true;
            this.SuButton.Click += new System.EventHandler(this.SuButton_Click);
            // 
            // SuSicaklikBox
            // 
            this.SuSicaklikBox.Location = new System.Drawing.Point(187, 163);
            this.SuSicaklikBox.Name = "SuSicaklikBox";
            this.SuSicaklikBox.Size = new System.Drawing.Size(100, 20);
            this.SuSicaklikBox.TabIndex = 1;
            this.SuSicaklikBox.TextChanged += new System.EventHandler(this.SuSicaklikBox_TextChanged);
            // 
            // EvSicaklikBox
            // 
            this.EvSicaklikBox.Location = new System.Drawing.Point(187, 95);
            this.EvSicaklikBox.Name = "EvSicaklikBox";
            this.EvSicaklikBox.Size = new System.Drawing.Size(100, 20);
            this.EvSicaklikBox.TabIndex = 3;
            this.EvSicaklikBox.TextChanged += new System.EventHandler(this.EvSicaklikBox_TextChanged);
            // 
            // EvButton
            // 
            this.EvButton.Location = new System.Drawing.Point(293, 89);
            this.EvButton.Name = "EvButton";
            this.EvButton.Size = new System.Drawing.Size(75, 30);
            this.EvButton.TabIndex = 2;
            this.EvButton.Text = "Ev";
            this.EvButton.UseVisualStyleBackColor = true;
            this.EvButton.Click += new System.EventHandler(this.EvButton_Click);
            // 
            // EvSicaklikGoster
            // 
            this.EvSicaklikGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvSicaklikGoster.Location = new System.Drawing.Point(17, 93);
            this.EvSicaklikGoster.Name = "EvSicaklikGoster";
            this.EvSicaklikGoster.ReadOnly = true;
            this.EvSicaklikGoster.Size = new System.Drawing.Size(128, 22);
            this.EvSicaklikGoster.TabIndex = 4;
            this.EvSicaklikGoster.TextChanged += new System.EventHandler(this.EvSicaklikGoster_TextChanged);
            // 
            // SuSicaklikGoster
            // 
            this.SuSicaklikGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SuSicaklikGoster.Location = new System.Drawing.Point(17, 161);
            this.SuSicaklikGoster.Name = "SuSicaklikGoster";
            this.SuSicaklikGoster.ReadOnly = true;
            this.SuSicaklikGoster.Size = new System.Drawing.Size(128, 22);
            this.SuSicaklikGoster.TabIndex = 5;
            this.SuSicaklikGoster.TextChanged += new System.EventHandler(this.SuSicaklikGoster_TextChanged);
            // 
            // BilgiBox
            // 
            this.BilgiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiBox.Location = new System.Drawing.Point(17, 29);
            this.BilgiBox.Name = "BilgiBox";
            this.BilgiBox.Size = new System.Drawing.Size(351, 26);
            this.BilgiBox.TabIndex = 6;
            this.BilgiBox.TextChanged += new System.EventHandler(this.BilgiBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 214);
            this.Controls.Add(this.BilgiBox);
            this.Controls.Add(this.SuSicaklikGoster);
            this.Controls.Add(this.EvSicaklikGoster);
            this.Controls.Add(this.EvSicaklikBox);
            this.Controls.Add(this.EvButton);
            this.Controls.Add(this.SuSicaklikBox);
            this.Controls.Add(this.SuButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SuButton;
        private System.Windows.Forms.TextBox SuSicaklikBox;
        private System.Windows.Forms.TextBox EvSicaklikBox;
        private System.Windows.Forms.Button EvButton;
        private System.Windows.Forms.TextBox EvSicaklikGoster;
        private System.Windows.Forms.TextBox SuSicaklikGoster;
        private System.Windows.Forms.TextBox BilgiBox;
    }
}

