namespace ffxiv_data_eng2kor
{
    partial class MainForm
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
            this.button_OpenFile1 = new System.Windows.Forms.Button();
            this.label_OpenFile1 = new System.Windows.Forms.Label();
            this.button_StartConversion = new System.Windows.Forms.Button();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.label_SaveFile = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_DataLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DataLocation = new System.Windows.Forms.TextBox();
            this.label_OpenFile2 = new System.Windows.Forms.Label();
            this.button_OpenFile2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OpenFile1
            // 
            this.button_OpenFile1.Location = new System.Drawing.Point(8, 5);
            this.button_OpenFile1.Name = "button_OpenFile1";
            this.button_OpenFile1.Size = new System.Drawing.Size(93, 29);
            this.button_OpenFile1.TabIndex = 0;
            this.button_OpenFile1.Text = "파일 선택";
            this.button_OpenFile1.UseVisualStyleBackColor = true;
            this.button_OpenFile1.Click += new System.EventHandler(this.button_OpenFile1_Click);
            // 
            // label_OpenFile1
            // 
            this.label_OpenFile1.AutoSize = true;
            this.label_OpenFile1.Location = new System.Drawing.Point(107, 9);
            this.label_OpenFile1.Name = "label_OpenFile1";
            this.label_OpenFile1.Size = new System.Drawing.Size(134, 21);
            this.label_OpenFile1.TabIndex = 8;
            this.label_OpenFile1.Text = "선택한 파일 이름";
            // 
            // button_StartConversion
            // 
            this.button_StartConversion.Location = new System.Drawing.Point(8, 145);
            this.button_StartConversion.Name = "button_StartConversion";
            this.button_StartConversion.Size = new System.Drawing.Size(93, 29);
            this.button_StartConversion.TabIndex = 2;
            this.button_StartConversion.Text = "변환 시작";
            this.button_StartConversion.UseVisualStyleBackColor = true;
            this.button_StartConversion.Click += new System.EventHandler(this.button_StartConversion_Click);
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(8, 110);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(93, 29);
            this.button_saveFile.TabIndex = 1;
            this.button_saveFile.Text = "경로 지정";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // label_SaveFile
            // 
            this.label_SaveFile.AutoSize = true;
            this.label_SaveFile.Location = new System.Drawing.Point(107, 114);
            this.label_SaveFile.Name = "label_SaveFile";
            this.label_SaveFile.Size = new System.Drawing.Size(134, 21);
            this.label_SaveFile.TabIndex = 9;
            this.label_SaveFile.Text = "저장할 파일 이름";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(107, 149);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(80, 21);
            this.label_Status.TabIndex = 10;
            this.label_Status.Text = "변환 준비";
            // 
            // label_DataLocation
            // 
            this.label_DataLocation.AutoSize = true;
            this.label_DataLocation.Location = new System.Drawing.Point(8, 78);
            this.label_DataLocation.Name = "label_DataLocation";
            this.label_DataLocation.Size = new System.Drawing.Size(100, 21);
            this.label_DataLocation.TabIndex = 11;
            this.label_DataLocation.Text = "데이터 위치:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "번째";
            // 
            // textBox_DataLocation
            // 
            this.textBox_DataLocation.Location = new System.Drawing.Point(108, 75);
            this.textBox_DataLocation.Name = "textBox_DataLocation";
            this.textBox_DataLocation.Size = new System.Drawing.Size(32, 29);
            this.textBox_DataLocation.TabIndex = 14;
            this.textBox_DataLocation.Text = "2";
            // 
            // label_OpenFile2
            // 
            this.label_OpenFile2.AutoSize = true;
            this.label_OpenFile2.Location = new System.Drawing.Point(107, 44);
            this.label_OpenFile2.Name = "label_OpenFile2";
            this.label_OpenFile2.Size = new System.Drawing.Size(134, 21);
            this.label_OpenFile2.TabIndex = 23;
            this.label_OpenFile2.Text = "선택한 파일 이름";
            // 
            // button_OpenFile2
            // 
            this.button_OpenFile2.Location = new System.Drawing.Point(8, 40);
            this.button_OpenFile2.Name = "button_OpenFile2";
            this.button_OpenFile2.Size = new System.Drawing.Size(93, 29);
            this.button_OpenFile2.TabIndex = 22;
            this.button_OpenFile2.Text = "파일 선택";
            this.button_OpenFile2.UseVisualStyleBackColor = true;
            this.button_OpenFile2.Click += new System.EventHandler(this.button_OpenFile2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(307, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "v20191230.1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_OpenFile2);
            this.Controls.Add(this.button_OpenFile2);
            this.Controls.Add(this.textBox_DataLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_DataLocation);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_SaveFile);
            this.Controls.Add(this.button_saveFile);
            this.Controls.Add(this.button_StartConversion);
            this.Controls.Add(this.label_OpenFile1);
            this.Controls.Add(this.button_OpenFile1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FFXIV DATA Eng2Kor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_OpenFile1;
        private System.Windows.Forms.Label label_OpenFile1;
        private System.Windows.Forms.Button button_StartConversion;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.Label label_SaveFile;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_DataLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DataLocation;
        private System.Windows.Forms.Label label_OpenFile2;
        private System.Windows.Forms.Button button_OpenFile2;
        private System.Windows.Forms.Label label1;
    }
}

