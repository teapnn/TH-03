namespace Bai02_Client
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.SERVER = new System.Windows.Forms.Label();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(105, 77);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(154, 20);
            this.txtServer.TabIndex = 24;
            // 
            // SERVER
            // 
            this.SERVER.AutoSize = true;
            this.SERVER.Location = new System.Drawing.Point(32, 80);
            this.SERVER.Name = "SERVER";
            this.SERVER.Size = new System.Drawing.Size(51, 13);
            this.SERVER.TabIndex = 23;
            this.SERVER.Text = "SERVER";
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(281, 121);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(91, 68);
            this.btnBao.TabIndex = 22;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(149, 121);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(91, 68);
            this.btnBua.TabIndex = 21;
            this.btnBua.Text = "Bua";
            this.btnBua.UseVisualStyleBackColor = true;
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(19, 121);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(91, 68);
            this.btnKeo.TabIndex = 20;
            this.btnKeo.Text = "Keo";
            this.btnKeo.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(105, 276);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(154, 20);
            this.txtResult.TabIndex = 19;
            // 
            // txtSelection
            // 
            this.txtSelection.Enabled = false;
            this.txtSelection.Location = new System.Drawing.Point(105, 38);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(154, 20);
            this.txtSelection.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Your Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 334);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.SERVER);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label SERVER;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

