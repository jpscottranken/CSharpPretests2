namespace Pretest01_06
{
    partial class frmDistanceConverter
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
            this.lblDIstanceInFeet = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDistanceInFeet = new System.Windows.Forms.TextBox();
            this.btnConvertToYds = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDIstanceInFeet
            // 
            this.lblDIstanceInFeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDIstanceInFeet.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIstanceInFeet.ForeColor = System.Drawing.Color.White;
            this.lblDIstanceInFeet.Location = new System.Drawing.Point(101, 51);
            this.lblDIstanceInFeet.Name = "lblDIstanceInFeet";
            this.lblDIstanceInFeet.Size = new System.Drawing.Size(190, 43);
            this.lblDIstanceInFeet.TabIndex = 5;
            this.lblDIstanceInFeet.Text = "Distance In Feet:";
            this.lblDIstanceInFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(101, 318);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(455, 45);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDistanceInFeet
            // 
            this.txtDistanceInFeet.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceInFeet.Location = new System.Drawing.Point(104, 127);
            this.txtDistanceInFeet.Name = "txtDistanceInFeet";
            this.txtDistanceInFeet.Size = new System.Drawing.Size(187, 38);
            this.txtDistanceInFeet.TabIndex = 0;
            this.txtDistanceInFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertToYds
            // 
            this.btnConvertToYds.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToYds.Location = new System.Drawing.Point(104, 201);
            this.btnConvertToYds.Name = "btnConvertToYds";
            this.btnConvertToYds.Size = new System.Drawing.Size(187, 68);
            this.btnConvertToYds.TabIndex = 1;
            this.btnConvertToYds.Text = "&Convert To Yds";
            this.btnConvertToYds.UseVisualStyleBackColor = true;
            this.btnConvertToYds.Click += new System.EventHandler(this.btnConvertToYds_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(328, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 68);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(558, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDistanceConverter
            // 
            this.AcceptButton = this.btnConvertToYds;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertToYds);
            this.Controls.Add(this.txtDistanceInFeet);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDIstanceInFeet);
            this.Name = "frmDistanceConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDIstanceInFeet;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDistanceInFeet;
        private System.Windows.Forms.Button btnConvertToYds;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

