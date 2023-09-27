namespace ST10116374_PROG7312_POE
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
            this.FindCallBT = new System.Windows.Forms.Button();
            this.IdAreaBT = new System.Windows.Forms.Button();
            this.ReBooksBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindCallBT
            // 
            this.FindCallBT.Location = new System.Drawing.Point(557, 188);
            this.FindCallBT.Name = "FindCallBT";
            this.FindCallBT.Size = new System.Drawing.Size(83, 53);
            this.FindCallBT.TabIndex = 0;
            this.FindCallBT.Text = "Finding Call Numbers";
            this.FindCallBT.UseVisualStyleBackColor = true;
            this.FindCallBT.Click += new System.EventHandler(this.FindCallBT_Click);
            // 
            // IdAreaBT
            // 
            this.IdAreaBT.Location = new System.Drawing.Point(367, 188);
            this.IdAreaBT.Name = "IdAreaBT";
            this.IdAreaBT.Size = new System.Drawing.Size(89, 53);
            this.IdAreaBT.TabIndex = 1;
            this.IdAreaBT.Text = "Identifying Areas";
            this.IdAreaBT.UseVisualStyleBackColor = true;
            this.IdAreaBT.Click += new System.EventHandler(this.IdAreaBT_Click);
            // 
            // ReBooksBT
            // 
            this.ReBooksBT.Location = new System.Drawing.Point(186, 188);
            this.ReBooksBT.Name = "ReBooksBT";
            this.ReBooksBT.Size = new System.Drawing.Size(96, 53);
            this.ReBooksBT.TabIndex = 2;
            this.ReBooksBT.Text = "Replacing Books";
            this.ReBooksBT.UseVisualStyleBackColor = true;
            this.ReBooksBT.Click += new System.EventHandler(this.ReBooksBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the librarian APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLease choose an activity";
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(367, 293);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(89, 54);
            this.CloseBT.TabIndex = 5;
            this.CloseBT.Text = "Close app";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReBooksBT);
            this.Controls.Add(this.IdAreaBT);
            this.Controls.Add(this.FindCallBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindCallBT;
        private System.Windows.Forms.Button IdAreaBT;
        private System.Windows.Forms.Button ReBooksBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseBT;
    }
}

