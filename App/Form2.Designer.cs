namespace ICOM
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.present = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 도현", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ICOM 사용 기록";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // present
            // 
            this.present.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.present.Location = new System.Drawing.Point(79, 145);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(265, 107);
            this.present.TabIndex = 1;
            this.present.Text = "헌옷 입력하기";
            this.present.UseVisualStyleBackColor = true;
            this.present.Click += new System.EventHandler(this.button1_Click);
            // 
            // previous
            // 
            this.previous.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previous.Location = new System.Drawing.Point(79, 282);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(265, 107);
            this.previous.TabIndex = 2;
            this.previous.Text = "이전 사용 기록 조회";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 530);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.present);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button present;
        private Button previous;
    }
}