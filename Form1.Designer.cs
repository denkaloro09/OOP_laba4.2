namespace Laba4_2oop
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.tbar1 = new System.Windows.Forms.TrackBar();
            this.tbar2 = new System.Windows.Forms.TrackBar();
            this.tbar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar3)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(37, 56);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(120, 20);
            this.tb1.TabIndex = 0;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(188, 56);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(120, 20);
            this.tb2.TabIndex = 1;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(342, 56);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(120, 20);
            this.tb3.TabIndex = 2;
            this.tb3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb3_KeyDown);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(37, 93);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 20);
            this.nud1.TabIndex = 3;
            this.nud1.ValueChanged += new System.EventHandler(this.nud1_ValueChanged);
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(188, 92);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 20);
            this.nud2.TabIndex = 4;
            this.nud2.ValueChanged += new System.EventHandler(this.nud2_ValueChanged);
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(342, 92);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(120, 20);
            this.nud3.TabIndex = 5;
            this.nud3.ValueChanged += new System.EventHandler(this.nud3_ValueChanged);
            // 
            // tbar1
            // 
            this.tbar1.Location = new System.Drawing.Point(37, 120);
            this.tbar1.Maximum = 100;
            this.tbar1.Name = "tbar1";
            this.tbar1.Size = new System.Drawing.Size(120, 45);
            this.tbar1.TabIndex = 6;
            this.tbar1.Scroll += new System.EventHandler(this.tbar1_Scroll);
            // 
            // tbar2
            // 
            this.tbar2.Location = new System.Drawing.Point(188, 119);
            this.tbar2.Maximum = 100;
            this.tbar2.Name = "tbar2";
            this.tbar2.Size = new System.Drawing.Size(120, 45);
            this.tbar2.TabIndex = 7;
            this.tbar2.Scroll += new System.EventHandler(this.tbar2_Scroll);
            // 
            // tbar3
            // 
            this.tbar3.Location = new System.Drawing.Point(342, 119);
            this.tbar3.Maximum = 100;
            this.tbar3.Name = "tbar3";
            this.tbar3.Size = new System.Drawing.Size(120, 45);
            this.tbar3.TabIndex = 8;
            this.tbar3.Scroll += new System.EventHandler(this.tbar3_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 243);
            this.Controls.Add(this.tbar3);
            this.Controls.Add(this.tbar2);
            this.Controls.Add(this.tbar1);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.TrackBar tbar1;
        private System.Windows.Forms.TrackBar tbar2;
        private System.Windows.Forms.TrackBar tbar3;
    }
}

