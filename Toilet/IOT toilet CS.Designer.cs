﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pninout1 = new System.Windows.Forms.Panel();
            this.pbinout = new System.Windows.Forms.PictureBox();
            this.pncall1 = new System.Windows.Forms.Panel();
            this.pbcall = new System.Windows.Forms.PictureBox();
            this.pnts = new System.Windows.Forms.Panel();
            this.pbts = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.pninout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinout)).BeginInit();
            this.pncall1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcall)).BeginInit();
            this.pnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(83, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 62);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(440, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 62);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(836, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 62);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pninout1
            // 
            this.pninout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pninout1.Controls.Add(this.pbinout);
            this.pninout1.Location = new System.Drawing.Point(83, 97);
            this.pninout1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pninout1.Name = "pninout1";
            this.pninout1.Size = new System.Drawing.Size(331, 305);
            this.pninout1.TabIndex = 3;
            this.pninout1.Paint += new System.Windows.Forms.PaintEventHandler(this.pninout1_Paint);
            // 
            // pbinout
            // 
            this.pbinout.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pbinout.Location = new System.Drawing.Point(66, 37);
            this.pbinout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbinout.Name = "pbinout";
            this.pbinout.Size = new System.Drawing.Size(191, 232);
            this.pbinout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbinout.TabIndex = 5;
            this.pbinout.TabStop = false;
            // 
            // pncall1
            // 
            this.pncall1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pncall1.Controls.Add(this.pbcall);
            this.pncall1.Location = new System.Drawing.Point(445, 97);
            this.pncall1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pncall1.Name = "pncall1";
            this.pncall1.Size = new System.Drawing.Size(362, 305);
            this.pncall1.TabIndex = 0;
            this.pncall1.Paint += new System.Windows.Forms.PaintEventHandler(this.pncall1_Paint);
            // 
            // pbcall
            // 
            this.pbcall.Image = global::WindowsFormsApp1.Properties.Resources.warn;
            this.pbcall.Location = new System.Drawing.Point(67, 37);
            this.pbcall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbcall.Name = "pbcall";
            this.pbcall.Size = new System.Drawing.Size(222, 222);
            this.pbcall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcall.TabIndex = 6;
            this.pbcall.TabStop = false;
            this.pbcall.Click += new System.EventHandler(this.pbcall_Click);
            // 
            // pnts
            // 
            this.pnts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnts.Controls.Add(this.pbts);
            this.pnts.Location = new System.Drawing.Point(836, 97);
            this.pnts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnts.Name = "pnts";
            this.pnts.Size = new System.Drawing.Size(351, 305);
            this.pnts.TabIndex = 4;
            // 
            // pbts
            // 
            this.pbts.Image = global::WindowsFormsApp1.Properties.Resources.pbts;
            this.pbts.Location = new System.Drawing.Point(66, 37);
            this.pbts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbts.Name = "pbts";
            this.pbts.Size = new System.Drawing.Size(222, 222);
            this.pbts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbts.TabIndex = 7;
            this.pbts.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1081, 564);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(724, 553);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1272, 696);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnts);
            this.Controls.Add(this.pncall1);
            this.Controls.Add(this.pninout1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "IOT Toilet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pninout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbinout)).EndInit();
            this.pncall1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcall)).EndInit();
            this.pnts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pninout1;
        private System.Windows.Forms.PictureBox pbinout;
        private System.Windows.Forms.Panel pncall1;
        private System.Windows.Forms.PictureBox pbcall;
        private System.Windows.Forms.Panel pnts;
        private System.Windows.Forms.PictureBox pbts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnReset;
    }
}

