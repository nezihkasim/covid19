namespace final_q2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.label_confirmed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_maxConfirmed = new System.Windows.Forms.TextBox();
            this.textBox_minConfirmed = new System.Windows.Forms.TextBox();
            this.button_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_minDeaths = new System.Windows.Forms.TextBox();
            this.textBox_maxDeaths = new System.Windows.Forms.TextBox();
            this.textBox_minRecovered = new System.Windows.Forms.TextBox();
            this.textBox_maxRecovered = new System.Windows.Forms.TextBox();
            this.textBox_minActive = new System.Windows.Forms.TextBox();
            this.max_Active = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(3, 76);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(82, 20);
            this.textBox_country.TabIndex = 1;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BackColor = System.Drawing.SystemColors.Control;
            this.label_country.Location = new System.Drawing.Point(3, 60);
            this.label_country.Name = "label_country";
            this.label_country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_country.Size = new System.Drawing.Size(82, 13);
            this.label_country.TabIndex = 2;
            this.label_country.Text = "Country/Region";
            // 
            // label_confirmed
            // 
            this.label_confirmed.AutoSize = true;
            this.label_confirmed.Location = new System.Drawing.Point(126, 30);
            this.label_confirmed.Name = "label_confirmed";
            this.label_confirmed.Size = new System.Drawing.Size(86, 13);
            this.label_confirmed.TabIndex = 3;
            this.label_confirmed.Text = "Confirmed Cases";
            this.label_confirmed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deaths";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recovered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Active";
            // 
            // textBox_maxConfirmed
            // 
            this.textBox_maxConfirmed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_maxConfirmed.Location = new System.Drawing.Point(129, 46);
            this.textBox_maxConfirmed.Name = "textBox_maxConfirmed";
            this.textBox_maxConfirmed.Size = new System.Drawing.Size(83, 20);
            this.textBox_maxConfirmed.TabIndex = 12;
            this.textBox_maxConfirmed.Text = "99999999";
            // 
            // textBox_minConfirmed
            // 
            this.textBox_minConfirmed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_minConfirmed.Location = new System.Drawing.Point(129, 76);
            this.textBox_minConfirmed.Name = "textBox_minConfirmed";
            this.textBox_minConfirmed.Size = new System.Drawing.Size(83, 20);
            this.textBox_minConfirmed.TabIndex = 13;
            this.textBox_minConfirmed.Text = "0";
            this.textBox_minConfirmed.TextChanged += new System.EventHandler(this.textBox_maxConfirmed_TextChanged);
            // 
            // button_show
            // 
            this.button_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_show.Location = new System.Drawing.Point(405, 113);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(244, 48);
            this.button_show.TabIndex = 14;
            this.button_show.Text = "SHOW";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(100, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(100, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "min";
            // 
            // textBox_minDeaths
            // 
            this.textBox_minDeaths.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_minDeaths.Location = new System.Drawing.Point(237, 76);
            this.textBox_minDeaths.Name = "textBox_minDeaths";
            this.textBox_minDeaths.Size = new System.Drawing.Size(63, 20);
            this.textBox_minDeaths.TabIndex = 18;
            this.textBox_minDeaths.Text = "0";
            // 
            // textBox_maxDeaths
            // 
            this.textBox_maxDeaths.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_maxDeaths.Location = new System.Drawing.Point(237, 46);
            this.textBox_maxDeaths.Name = "textBox_maxDeaths";
            this.textBox_maxDeaths.Size = new System.Drawing.Size(63, 20);
            this.textBox_maxDeaths.TabIndex = 17;
            this.textBox_maxDeaths.Text = "99999999";
            // 
            // textBox_minRecovered
            // 
            this.textBox_minRecovered.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_minRecovered.Location = new System.Drawing.Point(326, 76);
            this.textBox_minRecovered.Name = "textBox_minRecovered";
            this.textBox_minRecovered.Size = new System.Drawing.Size(63, 20);
            this.textBox_minRecovered.TabIndex = 20;
            this.textBox_minRecovered.Text = "0";
            // 
            // textBox_maxRecovered
            // 
            this.textBox_maxRecovered.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_maxRecovered.Location = new System.Drawing.Point(326, 46);
            this.textBox_maxRecovered.Name = "textBox_maxRecovered";
            this.textBox_maxRecovered.Size = new System.Drawing.Size(63, 20);
            this.textBox_maxRecovered.TabIndex = 19;
            this.textBox_maxRecovered.Text = "99999999";
            // 
            // textBox_minActive
            // 
            this.textBox_minActive.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_minActive.Location = new System.Drawing.Point(405, 76);
            this.textBox_minActive.Name = "textBox_minActive";
            this.textBox_minActive.Size = new System.Drawing.Size(68, 20);
            this.textBox_minActive.TabIndex = 22;
            this.textBox_minActive.Text = "0";
            // 
            // max_Active
            // 
            this.max_Active.ForeColor = System.Drawing.SystemColors.InfoText;
            this.max_Active.Location = new System.Drawing.Point(405, 46);
            this.max_Active.Name = "max_Active";
            this.max_Active.Size = new System.Drawing.Size(68, 20);
            this.max_Active.TabIndex = 21;
            this.max_Active.Text = "99999999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "*Sort by Clicking the Column Headers in Datatable";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_minActive);
            this.Controls.Add(this.max_Active);
            this.Controls.Add(this.textBox_minRecovered);
            this.Controls.Add(this.textBox_maxRecovered);
            this.Controls.Add(this.textBox_minDeaths);
            this.Controls.Add(this.textBox_maxDeaths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.textBox_minConfirmed);
            this.Controls.Add(this.textBox_maxConfirmed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_confirmed);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label_confirmed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_maxConfirmed;
        private System.Windows.Forms.TextBox textBox_minConfirmed;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_minDeaths;
        private System.Windows.Forms.TextBox textBox_maxDeaths;
        private System.Windows.Forms.TextBox textBox_minRecovered;
        private System.Windows.Forms.TextBox textBox_maxRecovered;
        private System.Windows.Forms.TextBox textBox_minActive;
        private System.Windows.Forms.TextBox max_Active;
        private System.Windows.Forms.Label label6;
    }
}

