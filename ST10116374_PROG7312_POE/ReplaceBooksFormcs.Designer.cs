namespace ST10116374_PROG7312_POE
{
    partial class ReplaceBooksFormcs
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
            this.UserLBX = new System.Windows.Forms.ListBox();
            this.GenNumLBX = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenCallNumBT = new System.Windows.Forms.Button();
            this.CheckOrderBT = new System.Windows.Forms.Button();
            this.ReturnCloseBT = new System.Windows.Forms.Button();
            this.AddCallTB = new System.Windows.Forms.TextBox();
            this.AddNumBT = new System.Windows.Forms.Button();
            this.ClearBTU = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressBT = new System.Windows.Forms.Button();
            this.ItemsinlistPB = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // UserLBX
            // 
            this.UserLBX.FormattingEnabled = true;
            this.UserLBX.Location = new System.Drawing.Point(554, 64);
            this.UserLBX.Name = "UserLBX";
            this.UserLBX.Size = new System.Drawing.Size(117, 186);
            this.UserLBX.TabIndex = 0;
            // 
            // GenNumLBX
            // 
            this.GenNumLBX.FormattingEnabled = true;
            this.GenNumLBX.Location = new System.Drawing.Point(104, 64);
            this.GenNumLBX.Name = "GenNumLBX";
            this.GenNumLBX.Size = new System.Drawing.Size(124, 186);
            this.GenNumLBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Replace Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort call number in ascending order to one box to the next";
            // 
            // GenCallNumBT
            // 
            this.GenCallNumBT.Location = new System.Drawing.Point(124, 256);
            this.GenCallNumBT.Name = "GenCallNumBT";
            this.GenCallNumBT.Size = new System.Drawing.Size(75, 52);
            this.GenCallNumBT.TabIndex = 4;
            this.GenCallNumBT.Text = "Generate call Numbers";
            this.GenCallNumBT.UseVisualStyleBackColor = true;
            this.GenCallNumBT.Click += new System.EventHandler(this.GenCallNumBT_Click);
            // 
            // CheckOrderBT
            // 
            this.CheckOrderBT.Location = new System.Drawing.Point(575, 256);
            this.CheckOrderBT.Name = "CheckOrderBT";
            this.CheckOrderBT.Size = new System.Drawing.Size(75, 52);
            this.CheckOrderBT.TabIndex = 5;
            this.CheckOrderBT.Text = "Check Order";
            this.CheckOrderBT.UseVisualStyleBackColor = true;
            this.CheckOrderBT.Click += new System.EventHandler(this.CheckOrderBT_Click);
            // 
            // ReturnCloseBT
            // 
            this.ReturnCloseBT.Location = new System.Drawing.Point(342, 357);
            this.ReturnCloseBT.Name = "ReturnCloseBT";
            this.ReturnCloseBT.Size = new System.Drawing.Size(81, 23);
            this.ReturnCloseBT.TabIndex = 6;
            this.ReturnCloseBT.Text = "Return/Close";
            this.ReturnCloseBT.UseVisualStyleBackColor = true;
            this.ReturnCloseBT.Click += new System.EventHandler(this.ReturnCloseBT_Click);
            // 
            // AddCallTB
            // 
            this.AddCallTB.Location = new System.Drawing.Point(342, 77);
            this.AddCallTB.Name = "AddCallTB";
            this.AddCallTB.Size = new System.Drawing.Size(100, 20);
            this.AddCallTB.TabIndex = 7;
            // 
            // AddNumBT
            // 
            this.AddNumBT.Location = new System.Drawing.Point(342, 139);
            this.AddNumBT.Name = "AddNumBT";
            this.AddNumBT.Size = new System.Drawing.Size(81, 23);
            this.AddNumBT.TabIndex = 8;
            this.AddNumBT.Text = "Add call Number";
            this.AddNumBT.UseVisualStyleBackColor = true;
            this.AddNumBT.Click += new System.EventHandler(this.AddNumBT_Click);
            // 
            // ClearBTU
            // 
            this.ClearBTU.Location = new System.Drawing.Point(701, 138);
            this.ClearBTU.Name = "ClearBTU";
            this.ClearBTU.Size = new System.Drawing.Size(75, 23);
            this.ClearBTU.TabIndex = 9;
            this.ClearBTU.Text = "Clear Items";
            this.ClearBTU.UseVisualStyleBackColor = true;
            this.ClearBTU.Click += new System.EventHandler(this.ClearBTU_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Use this button to check wether your callnumbers are in the right asceding order";
            // 
            // ProgressBT
            // 
            this.ProgressBT.Location = new System.Drawing.Point(342, 181);
            this.ProgressBT.Name = "ProgressBT";
            this.ProgressBT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBT.Size = new System.Drawing.Size(81, 37);
            this.ProgressBT.TabIndex = 11;
            this.ProgressBT.Text = "Show Progress";
            this.ProgressBT.UseVisualStyleBackColor = true;
            this.ProgressBT.Click += new System.EventHandler(this.ProgressBT_Click);
            // 
            // ItemsinlistPB
            // 
            this.ItemsinlistPB.Location = new System.Drawing.Point(251, 226);
            this.ItemsinlistPB.Name = "ItemsinlistPB";
            this.ItemsinlistPB.Size = new System.Drawing.Size(276, 23);
            this.ItemsinlistPB.TabIndex = 12;
            // 
            // ReplaceBooksFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemsinlistPB);
            this.Controls.Add(this.ProgressBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearBTU);
            this.Controls.Add(this.AddNumBT);
            this.Controls.Add(this.AddCallTB);
            this.Controls.Add(this.ReturnCloseBT);
            this.Controls.Add(this.CheckOrderBT);
            this.Controls.Add(this.GenCallNumBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenNumLBX);
            this.Controls.Add(this.UserLBX);
            this.Name = "ReplaceBooksFormcs";
            this.Text = "ReplaceBooksFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserLBX;
        private System.Windows.Forms.ListBox GenNumLBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenCallNumBT;
        private System.Windows.Forms.Button CheckOrderBT;
        private System.Windows.Forms.Button ReturnCloseBT;
        private System.Windows.Forms.TextBox AddCallTB;
        private System.Windows.Forms.Button AddNumBT;
        private System.Windows.Forms.Button ClearBTU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProgressBT;
        private System.Windows.Forms.ProgressBar ItemsinlistPB;
    }
}