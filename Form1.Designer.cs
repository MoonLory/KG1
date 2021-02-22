
namespace Lab1KG
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
            this.rgbPicture = new System.Windows.Forms.PictureBox();
            this.xyzPicture = new System.Windows.Forms.PictureBox();
            this.labPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rField = new System.Windows.Forms.TextBox();
            this.gField = new System.Windows.Forms.TextBox();
            this.b_Field = new System.Windows.Forms.TextBox();
            this.rgbButton = new System.Windows.Forms.Button();
            this.xyzButton = new System.Windows.Forms.Button();
            this.xFieldXYZ = new System.Windows.Forms.TextBox();
            this.yFieldXYZ = new System.Windows.Forms.TextBox();
            this.zFieldXYZ = new System.Windows.Forms.TextBox();
            this.lField = new System.Windows.Forms.TextBox();
            this.aField = new System.Windows.Forms.TextBox();
            this.bField = new System.Windows.Forms.TextBox();
            this.ShowLAB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rgbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbPicture
            // 
            this.rgbPicture.Location = new System.Drawing.Point(23, 32);
            this.rgbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.rgbPicture.Name = "rgbPicture";
            this.rgbPicture.Size = new System.Drawing.Size(155, 173);
            this.rgbPicture.TabIndex = 1;
            this.rgbPicture.TabStop = false;
            // 
            // xyzPicture
            // 
            this.xyzPicture.Location = new System.Drawing.Point(218, 32);
            this.xyzPicture.Margin = new System.Windows.Forms.Padding(2);
            this.xyzPicture.Name = "xyzPicture";
            this.xyzPicture.Size = new System.Drawing.Size(153, 173);
            this.xyzPicture.TabIndex = 2;
            this.xyzPicture.TabStop = false;
            // 
            // labPicture
            // 
            this.labPicture.Location = new System.Drawing.Point(404, 32);
            this.labPicture.Margin = new System.Windows.Forms.Padding(2);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(153, 173);
            this.labPicture.TabIndex = 3;
            this.labPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RGB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "XYZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LAB";
            // 
            // rField
            // 
            this.rField.Location = new System.Drawing.Point(64, 210);
            this.rField.Margin = new System.Windows.Forms.Padding(2);
            this.rField.Name = "rField";
            this.rField.Size = new System.Drawing.Size(80, 20);
            this.rField.TabIndex = 7;
            // 
            // gField
            // 
            this.gField.Location = new System.Drawing.Point(64, 241);
            this.gField.Margin = new System.Windows.Forms.Padding(2);
            this.gField.Name = "gField";
            this.gField.Size = new System.Drawing.Size(80, 20);
            this.gField.TabIndex = 8;
            // 
            // b_Field
            // 
            this.b_Field.Location = new System.Drawing.Point(64, 271);
            this.b_Field.Margin = new System.Windows.Forms.Padding(2);
            this.b_Field.Name = "b_Field";
            this.b_Field.Size = new System.Drawing.Size(80, 20);
            this.b_Field.TabIndex = 9;
            // 
            // rgbButton
            // 
            this.rgbButton.Location = new System.Drawing.Point(26, 320);
            this.rgbButton.Margin = new System.Windows.Forms.Padding(2);
            this.rgbButton.Name = "rgbButton";
            this.rgbButton.Size = new System.Drawing.Size(153, 19);
            this.rgbButton.TabIndex = 10;
            this.rgbButton.Text = "ShowRGB";
            this.rgbButton.UseVisualStyleBackColor = true;
            this.rgbButton.Click += new System.EventHandler(this.rgbButton_Click);
            // 
            // xyzButton
            // 
            this.xyzButton.Location = new System.Drawing.Point(218, 320);
            this.xyzButton.Margin = new System.Windows.Forms.Padding(2);
            this.xyzButton.Name = "xyzButton";
            this.xyzButton.Size = new System.Drawing.Size(153, 19);
            this.xyzButton.TabIndex = 11;
            this.xyzButton.Text = "ShowXYZ";
            this.xyzButton.UseVisualStyleBackColor = true;
            this.xyzButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xFieldXYZ
            // 
            this.xFieldXYZ.Location = new System.Drawing.Point(266, 210);
            this.xFieldXYZ.Margin = new System.Windows.Forms.Padding(2);
            this.xFieldXYZ.Name = "xFieldXYZ";
            this.xFieldXYZ.Size = new System.Drawing.Size(73, 20);
            this.xFieldXYZ.TabIndex = 12;
            // 
            // yFieldXYZ
            // 
            this.yFieldXYZ.Location = new System.Drawing.Point(266, 241);
            this.yFieldXYZ.Margin = new System.Windows.Forms.Padding(2);
            this.yFieldXYZ.Name = "yFieldXYZ";
            this.yFieldXYZ.Size = new System.Drawing.Size(73, 20);
            this.yFieldXYZ.TabIndex = 13;
            // 
            // zFieldXYZ
            // 
            this.zFieldXYZ.Location = new System.Drawing.Point(266, 271);
            this.zFieldXYZ.Margin = new System.Windows.Forms.Padding(2);
            this.zFieldXYZ.Name = "zFieldXYZ";
            this.zFieldXYZ.Size = new System.Drawing.Size(73, 20);
            this.zFieldXYZ.TabIndex = 14;
            // 
            // lField
            // 
            this.lField.Location = new System.Drawing.Point(457, 210);
            this.lField.Margin = new System.Windows.Forms.Padding(2);
            this.lField.Name = "lField";
            this.lField.Size = new System.Drawing.Size(75, 20);
            this.lField.TabIndex = 15;
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(457, 241);
            this.aField.Margin = new System.Windows.Forms.Padding(2);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(75, 20);
            this.aField.TabIndex = 16;
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(457, 280);
            this.bField.Margin = new System.Windows.Forms.Padding(2);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(75, 20);
            this.bField.TabIndex = 17;
            // 
            // ShowLAB
            // 
            this.ShowLAB.Location = new System.Drawing.Point(404, 320);
            this.ShowLAB.Margin = new System.Windows.Forms.Padding(2);
            this.ShowLAB.Name = "ShowLAB";
            this.ShowLAB.Size = new System.Drawing.Size(153, 19);
            this.ShowLAB.TabIndex = 18;
            this.ShowLAB.Text = "ShowLAB";
            this.ShowLAB.UseVisualStyleBackColor = true;
            this.ShowLAB.Click += new System.EventHandler(this.ShowLAB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ShowLAB);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.aField);
            this.Controls.Add(this.lField);
            this.Controls.Add(this.zFieldXYZ);
            this.Controls.Add(this.yFieldXYZ);
            this.Controls.Add(this.xFieldXYZ);
            this.Controls.Add(this.xyzButton);
            this.Controls.Add(this.rgbButton);
            this.Controls.Add(this.b_Field);
            this.Controls.Add(this.gField);
            this.Controls.Add(this.rField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPicture);
            this.Controls.Add(this.xyzPicture);
            this.Controls.Add(this.rgbPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CG1_Hryshkin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyzPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox rgbPicture;
        private System.Windows.Forms.PictureBox xyzPicture;
        private System.Windows.Forms.PictureBox labPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rField;
        private System.Windows.Forms.TextBox gField;
        private System.Windows.Forms.TextBox b_Field;
        private System.Windows.Forms.Button rgbButton;
        private System.Windows.Forms.Button xyzButton;
        private System.Windows.Forms.TextBox xFieldXYZ;
        private System.Windows.Forms.TextBox yFieldXYZ;
        private System.Windows.Forms.TextBox zFieldXYZ;
        private System.Windows.Forms.TextBox lField;
        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.Button ShowLAB;
    }
}

