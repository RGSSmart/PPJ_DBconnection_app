
namespace PokazniPrimerRadaSaBazom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.txtImeKlijenta = new System.Windows.Forms.TextBox();
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabela.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(250, 47);
            this.btnDodajKlijenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(143, 31);
            this.btnDodajKlijenta.TabIndex = 1;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // txtImeKlijenta
            // 
            this.txtImeKlijenta.Location = new System.Drawing.Point(45, 48);
            this.txtImeKlijenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImeKlijenta.Name = "txtImeKlijenta";
            this.txtImeKlijenta.Size = new System.Drawing.Size(198, 27);
            this.txtImeKlijenta.TabIndex = 3;
            // 
            // tabela
            // 
            this.tabela.AutoScroll = true;
            this.tabela.AutoSize = true;
            this.tabela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabela.ColumnCount = 3;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.92982F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.07018F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tabela.Controls.Add(this.label1, 0, 0);
            this.tabela.Controls.Add(this.label2, 1, 0);
            this.tabela.Controls.Add(this.label3, 2, 0);
            this.tabela.Location = new System.Drawing.Point(45, 86);
            this.tabela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabela.Name = "tabela";
            this.tabela.RowCount = 1;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabela.Size = new System.Drawing.Size(699, 361);
            this.tabela.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i ID klijenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Akcija brisanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Akcija izmene";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(773, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.txtImeKlijenta);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabela.ResumeLayout(false);
            this.tabela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.TextBox txtImeKlijenta;
        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

