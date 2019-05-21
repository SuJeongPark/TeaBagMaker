namespace TeaBagMaker
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
            this.teaList = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teaList
            // 
            this.teaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teaList.FormattingEnabled = true;
            this.teaList.Location = new System.Drawing.Point(12, 12);
            this.teaList.Name = "teaList";
            this.teaList.Size = new System.Drawing.Size(204, 20);
            this.teaList.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(13, 39);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(203, 35);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기!";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(13, 81);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 288);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.teaList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaList;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label result;
    }
}

