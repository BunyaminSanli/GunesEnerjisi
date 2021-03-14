
namespace GunesEnerjisi
{
    partial class HibritSistem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HibritSistem));
            this.SuButton = new System.Windows.Forms.Button();
            this.SuSicaklikBox = new System.Windows.Forms.TextBox();
            this.EvSicaklikBox = new System.Windows.Forms.TextBox();
            this.EvButton = new System.Windows.Forms.Button();
            this.EvSicaklikGoster = new System.Windows.Forms.TextBox();
            this.SuSicaklikGoster = new System.Windows.Forms.TextBox();
            this.BilgiBox1 = new System.Windows.Forms.TextBox();
            this.BilgiBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SuButton
            // 
            this.SuButton.Location = new System.Drawing.Point(383, 73);
            this.SuButton.Name = "SuButton";
            this.SuButton.Size = new System.Drawing.Size(75, 54);
            this.SuButton.TabIndex = 0;
            this.SuButton.Text = "Su";
            this.SuButton.UseVisualStyleBackColor = true;
            this.SuButton.Click += new System.EventHandler(this.SuButton_Click);
            // 
            // SuSicaklikBox
            // 
            this.SuSicaklikBox.Location = new System.Drawing.Point(273, 107);
            this.SuSicaklikBox.Name = "SuSicaklikBox";
            this.SuSicaklikBox.Size = new System.Drawing.Size(104, 20);
            this.SuSicaklikBox.TabIndex = 1;
            this.SuSicaklikBox.TextChanged += new System.EventHandler(this.SuSicaklikBox_TextChanged);
            // 
            // EvSicaklikBox
            // 
            this.EvSicaklikBox.Location = new System.Drawing.Point(15, 107);
            this.EvSicaklikBox.Name = "EvSicaklikBox";
            this.EvSicaklikBox.Size = new System.Drawing.Size(104, 20);
            this.EvSicaklikBox.TabIndex = 3;
            this.EvSicaklikBox.TextChanged += new System.EventHandler(this.EvSicaklikBox_TextChanged);
            // 
            // EvButton
            // 
            this.EvButton.Location = new System.Drawing.Point(125, 73);
            this.EvButton.Name = "EvButton";
            this.EvButton.Size = new System.Drawing.Size(75, 54);
            this.EvButton.TabIndex = 2;
            this.EvButton.Text = "Ev";
            this.EvButton.UseVisualStyleBackColor = true;
            this.EvButton.Click += new System.EventHandler(this.EvButton_Click);
            // 
            // EvSicaklikGoster
            // 
            this.EvSicaklikGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvSicaklikGoster.Location = new System.Drawing.Point(15, 73);
            this.EvSicaklikGoster.Name = "EvSicaklikGoster";
            this.EvSicaklikGoster.ReadOnly = true;
            this.EvSicaklikGoster.Size = new System.Drawing.Size(104, 22);
            this.EvSicaklikGoster.TabIndex = 4;
            this.EvSicaklikGoster.TextChanged += new System.EventHandler(this.EvSicaklikGoster_TextChanged);
            // 
            // SuSicaklikGoster
            // 
            this.SuSicaklikGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SuSicaklikGoster.Location = new System.Drawing.Point(273, 73);
            this.SuSicaklikGoster.Name = "SuSicaklikGoster";
            this.SuSicaklikGoster.ReadOnly = true;
            this.SuSicaklikGoster.Size = new System.Drawing.Size(104, 22);
            this.SuSicaklikGoster.TabIndex = 5;
            this.SuSicaklikGoster.TextChanged += new System.EventHandler(this.SuSicaklikGoster_TextChanged);
            // 
            // BilgiBox1
            // 
            this.BilgiBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiBox1.Location = new System.Drawing.Point(15, 41);
            this.BilgiBox1.Name = "BilgiBox1";
            this.BilgiBox1.ReadOnly = true;
            this.BilgiBox1.Size = new System.Drawing.Size(185, 21);
            this.BilgiBox1.TabIndex = 6;
            this.BilgiBox1.TextChanged += new System.EventHandler(this.BilgiBox_TextChanged);
            // 
            // BilgiBox2
            // 
            this.BilgiBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiBox2.Location = new System.Drawing.Point(273, 41);
            this.BilgiBox2.Name = "BilgiBox2";
            this.BilgiBox2.ReadOnly = true;
            this.BilgiBox2.Size = new System.Drawing.Size(185, 21);
            this.BilgiBox2.TabIndex = 7;
            // 
            // HibritSistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 171);
            this.Controls.Add(this.BilgiBox2);
            this.Controls.Add(this.BilgiBox1);
            this.Controls.Add(this.SuSicaklikGoster);
            this.Controls.Add(this.EvSicaklikGoster);
            this.Controls.Add(this.EvSicaklikBox);
            this.Controls.Add(this.EvButton);
            this.Controls.Add(this.SuSicaklikBox);
            this.Controls.Add(this.SuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HibritSistem";
            this.Text = "Hibrit Sistem";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox BilgiBox1;
        private System.Windows.Forms.TextBox BilgiBox2;
    }
}

