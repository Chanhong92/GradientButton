
namespace GradientButton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientBT1 = new GradientButton.GradientBT();
            this.gradientBT2 = new GradientButton.GradientBT();
            this.gradientBT3 = new GradientButton.GradientBT();
            this.gradientBT4 = new GradientButton.GradientBT();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.gradientBT4);
            this.panel1.Controls.Add(this.gradientBT3);
            this.panel1.Controls.Add(this.gradientBT2);
            this.panel1.Controls.Add(this.gradientBT1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 452);
            this.panel1.TabIndex = 0;
            // 
            // gradientBT1
            // 
            this.gradientBT1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientBT1.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gradientBT1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gradientBT1.ForeColor = System.Drawing.Color.White;
            this.gradientBT1.Location = new System.Drawing.Point(0, 0);
            this.gradientBT1.Name = "gradientBT1";
            this.gradientBT1.RotateAngle = 45F;
            this.gradientBT1.SecondColor = System.Drawing.Color.DeepSkyBlue;
            this.gradientBT1.Selected = true;
            this.gradientBT1.Size = new System.Drawing.Size(154, 45);
            this.gradientBT1.SplitLine = 0.5F;
            this.gradientBT1.TabIndex = 1;
            this.gradientBT1.Text = "gradientBT1";
            this.gradientBT1.UseVisualStyleBackColor = true;
            // 
            // gradientBT2
            // 
            this.gradientBT2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientBT2.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gradientBT2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gradientBT2.ForeColor = System.Drawing.Color.White;
            this.gradientBT2.Location = new System.Drawing.Point(0, 45);
            this.gradientBT2.Name = "gradientBT2";
            this.gradientBT2.RotateAngle = 45F;
            this.gradientBT2.SecondColor = System.Drawing.Color.DeepSkyBlue;
            this.gradientBT2.Selected = false;
            this.gradientBT2.Size = new System.Drawing.Size(154, 45);
            this.gradientBT2.SplitLine = 0.5F;
            this.gradientBT2.TabIndex = 2;
            this.gradientBT2.Text = "gradientBT2";
            this.gradientBT2.UseVisualStyleBackColor = true;
            // 
            // gradientBT3
            // 
            this.gradientBT3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientBT3.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gradientBT3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gradientBT3.ForeColor = System.Drawing.Color.White;
            this.gradientBT3.Location = new System.Drawing.Point(0, 90);
            this.gradientBT3.Name = "gradientBT3";
            this.gradientBT3.RotateAngle = 45F;
            this.gradientBT3.SecondColor = System.Drawing.Color.DeepSkyBlue;
            this.gradientBT3.Selected = false;
            this.gradientBT3.Size = new System.Drawing.Size(154, 45);
            this.gradientBT3.SplitLine = 0.5F;
            this.gradientBT3.TabIndex = 3;
            this.gradientBT3.Text = "gradientBT3";
            this.gradientBT3.UseVisualStyleBackColor = true;
            // 
            // gradientBT4
            // 
            this.gradientBT4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientBT4.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gradientBT4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gradientBT4.ForeColor = System.Drawing.Color.White;
            this.gradientBT4.Location = new System.Drawing.Point(0, 135);
            this.gradientBT4.Name = "gradientBT4";
            this.gradientBT4.RotateAngle = 45F;
            this.gradientBT4.SecondColor = System.Drawing.Color.DeepSkyBlue;
            this.gradientBT4.Selected = false;
            this.gradientBT4.Size = new System.Drawing.Size(154, 45);
            this.gradientBT4.SplitLine = 0.5F;
            this.gradientBT4.TabIndex = 4;
            this.gradientBT4.Text = "gradientBT4";
            this.gradientBT4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(748, 452);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GradientBT gradientBT1;
        private GradientBT gradientBT4;
        private GradientBT gradientBT3;
        private GradientBT gradientBT2;
    }
}

