namespace LowfiWeedout {
  partial class MainForm {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.targetFolderTextBox = new System.Windows.Forms.TextBox();
      this.targetFolderButton = new System.Windows.Forms.Button();
      this.betterFolderBrowser = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.selectButton = new System.Windows.Forms.Button();
      this.fileNumberTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.fileCountLabel = new System.Windows.Forms.Label();
      this.totalFolderCountLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.deleteButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.prevButton = new System.Windows.Forms.Button();
      this.fileTextBox = new System.Windows.Forms.TextBox();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.imageGroupBox = new System.Windows.Forms.GroupBox();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.resetButton = new System.Windows.Forms.Button();
      this.sizeDownButton = new System.Windows.Forms.Button();
      this.sizeUpButton = new System.Windows.Forms.Button();
      this.autoFaceCheckBox = new System.Windows.Forms.CheckBox();
      this.faceTextBox = new System.Windows.Forms.TextBox();
      this.saveButton = new System.Windows.Forms.Button();
      this.imageSizeLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.imageGroupBox.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.targetFolderTextBox);
      this.groupBox1.Controls.Add(this.targetFolderButton);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1500, 53);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "대상폴더";
      // 
      // targetFolderTextBox
      // 
      this.targetFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.targetFolderTextBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.targetFolderTextBox.Location = new System.Drawing.Point(149, 21);
      this.targetFolderTextBox.Name = "targetFolderTextBox";
      this.targetFolderTextBox.ReadOnly = true;
      this.targetFolderTextBox.Size = new System.Drawing.Size(655, 25);
      this.targetFolderTextBox.TabIndex = 1;
      this.targetFolderTextBox.Text = "...";
      // 
      // targetFolderButton
      // 
      this.targetFolderButton.BackColor = System.Drawing.Color.Salmon;
      this.targetFolderButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.targetFolderButton.Location = new System.Drawing.Point(6, 20);
      this.targetFolderButton.Name = "targetFolderButton";
      this.targetFolderButton.Size = new System.Drawing.Size(136, 23);
      this.targetFolderButton.TabIndex = 0;
      this.targetFolderButton.Text = "대상폴더선택하기";
      this.targetFolderButton.UseVisualStyleBackColor = false;
      this.targetFolderButton.Click += new System.EventHandler(this.targetFolderButton_Click);
      // 
      // betterFolderBrowser
      // 
      this.betterFolderBrowser.Multiselect = false;
      this.betterFolderBrowser.RootFolder = "C:\\Users\\Garlic\\Desktop";
      this.betterFolderBrowser.Title = "Please select a folder...";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.selectButton);
      this.groupBox2.Controls.Add(this.fileNumberTextBox);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.fileCountLabel);
      this.groupBox2.Controls.Add(this.totalFolderCountLabel);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(1326, 73);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(187, 142);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "폴더정보";
      // 
      // selectButton
      // 
      this.selectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.selectButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.selectButton.Location = new System.Drawing.Point(95, 91);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(76, 26);
      this.selectButton.TabIndex = 8;
      this.selectButton.Text = "보기";
      this.selectButton.UseVisualStyleBackColor = false;
      this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
      // 
      // fileNumberTextBox
      // 
      this.fileNumberTextBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.fileNumberTextBox.Location = new System.Drawing.Point(8, 91);
      this.fileNumberTextBox.Name = "fileNumberTextBox";
      this.fileNumberTextBox.Size = new System.Drawing.Size(81, 25);
      this.fileNumberTextBox.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label5.Location = new System.Drawing.Point(6, 75);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 17);
      this.label5.TabIndex = 6;
      this.label5.Text = "파일번호";
      // 
      // fileCountLabel
      // 
      this.fileCountLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.fileCountLabel.Location = new System.Drawing.Point(85, 49);
      this.fileCountLabel.Name = "fileCountLabel";
      this.fileCountLabel.Size = new System.Drawing.Size(73, 17);
      this.fileCountLabel.TabIndex = 3;
      this.fileCountLabel.Text = "0";
      // 
      // totalFolderCountLabel
      // 
      this.totalFolderCountLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.totalFolderCountLabel.Location = new System.Drawing.Point(85, 27);
      this.totalFolderCountLabel.Name = "totalFolderCountLabel";
      this.totalFolderCountLabel.Size = new System.Drawing.Size(73, 22);
      this.totalFolderCountLabel.TabIndex = 2;
      this.totalFolderCountLabel.Text = "0";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(6, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "총 파일 개수";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(6, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "총 폴더 개수";
      // 
      // deleteButton
      // 
      this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteButton.BackColor = System.Drawing.Color.Red;
      this.deleteButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.deleteButton.ForeColor = System.Drawing.Color.White;
      this.deleteButton.Location = new System.Drawing.Point(1399, 745);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(114, 59);
      this.deleteButton.TabIndex = 2;
      this.deleteButton.Text = "삭제하기\r\n(Del)\r\n";
      this.deleteButton.UseVisualStyleBackColor = false;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // nextButton
      // 
      this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.nextButton.BackColor = System.Drawing.Color.LightCyan;
      this.nextButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.nextButton.Location = new System.Drawing.Point(139, 745);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(114, 59);
      this.nextButton.TabIndex = 3;
      this.nextButton.Text = "다음사진\r\n( → )\r\n";
      this.nextButton.UseVisualStyleBackColor = false;
      this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
      // 
      // prevButton
      // 
      this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.prevButton.BackColor = System.Drawing.Color.LightBlue;
      this.prevButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.prevButton.Location = new System.Drawing.Point(19, 745);
      this.prevButton.Name = "prevButton";
      this.prevButton.Size = new System.Drawing.Size(114, 59);
      this.prevButton.TabIndex = 4;
      this.prevButton.Text = "이전사진\r\n( ← )\r\n";
      this.prevButton.UseVisualStyleBackColor = false;
      this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
      // 
      // fileTextBox
      // 
      this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.fileTextBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.fileTextBox.Location = new System.Drawing.Point(989, 709);
      this.fileTextBox.Name = "fileTextBox";
      this.fileTextBox.ReadOnly = true;
      this.fileTextBox.Size = new System.Drawing.Size(524, 25);
      this.fileTextBox.TabIndex = 5;
      // 
      // pictureBox
      // 
      this.pictureBox.BackColor = System.Drawing.Color.Black;
      this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
      this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox.Location = new System.Drawing.Point(3, 21);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(1301, 606);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox.TabIndex = 6;
      this.pictureBox.TabStop = false;
      this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
      // 
      // imageGroupBox
      // 
      this.imageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.imageGroupBox.Controls.Add(this.pictureBox);
      this.imageGroupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.imageGroupBox.Location = new System.Drawing.Point(13, 73);
      this.imageGroupBox.Name = "imageGroupBox";
      this.imageGroupBox.Size = new System.Drawing.Size(1307, 630);
      this.imageGroupBox.TabIndex = 7;
      this.imageGroupBox.TabStop = false;
      this.imageGroupBox.Text = "이미지";
      // 
      // timer
      // 
      this.timer.Interval = 33;
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox4.Controls.Add(this.resetButton);
      this.groupBox4.Controls.Add(this.sizeDownButton);
      this.groupBox4.Controls.Add(this.sizeUpButton);
      this.groupBox4.Controls.Add(this.autoFaceCheckBox);
      this.groupBox4.Controls.Add(this.faceTextBox);
      this.groupBox4.Location = new System.Drawing.Point(1324, 222);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(189, 478);
      this.groupBox4.TabIndex = 8;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "수정";
      // 
      // resetButton
      // 
      this.resetButton.Location = new System.Drawing.Point(7, 168);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(176, 23);
      this.resetButton.TabIndex = 4;
      this.resetButton.Text = "원본으로(ESC)";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // sizeDownButton
      // 
      this.sizeDownButton.Location = new System.Drawing.Point(98, 213);
      this.sizeDownButton.Name = "sizeDownButton";
      this.sizeDownButton.Size = new System.Drawing.Size(75, 23);
      this.sizeDownButton.TabIndex = 3;
      this.sizeDownButton.Text = "작게(↓)";
      this.sizeDownButton.UseVisualStyleBackColor = true;
      this.sizeDownButton.Click += new System.EventHandler(this.sizeDownButton_Click);
      // 
      // sizeUpButton
      // 
      this.sizeUpButton.Location = new System.Drawing.Point(16, 213);
      this.sizeUpButton.Name = "sizeUpButton";
      this.sizeUpButton.Size = new System.Drawing.Size(75, 23);
      this.sizeUpButton.TabIndex = 2;
      this.sizeUpButton.Text = "크게(↑)";
      this.sizeUpButton.UseVisualStyleBackColor = true;
      this.sizeUpButton.Click += new System.EventHandler(this.sizeUpButton_Click);
      // 
      // autoFaceCheckBox
      // 
      this.autoFaceCheckBox.AutoSize = true;
      this.autoFaceCheckBox.Checked = true;
      this.autoFaceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.autoFaceCheckBox.Location = new System.Drawing.Point(7, 145);
      this.autoFaceCheckBox.Name = "autoFaceCheckBox";
      this.autoFaceCheckBox.Size = new System.Drawing.Size(104, 16);
      this.autoFaceCheckBox.TabIndex = 1;
      this.autoFaceCheckBox.Text = "자동 얼굴 찾기";
      this.autoFaceCheckBox.UseVisualStyleBackColor = true;
      this.autoFaceCheckBox.CheckedChanged += new System.EventHandler(this.autoFaceCheckBox_CheckedChanged);
      // 
      // faceTextBox
      // 
      this.faceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.faceTextBox.Location = new System.Drawing.Point(7, 21);
      this.faceTextBox.Multiline = true;
      this.faceTextBox.Name = "faceTextBox";
      this.faceTextBox.ReadOnly = true;
      this.faceTextBox.Size = new System.Drawing.Size(176, 117);
      this.faceTextBox.TabIndex = 0;
      // 
      // saveButton
      // 
      this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveButton.BackColor = System.Drawing.Color.DarkCyan;
      this.saveButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.saveButton.ForeColor = System.Drawing.Color.White;
      this.saveButton.Location = new System.Drawing.Point(1278, 745);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(114, 59);
      this.saveButton.TabIndex = 9;
      this.saveButton.Text = "저장하기\r\n(S)\r\n";
      this.saveButton.UseVisualStyleBackColor = false;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // imageSizeLabel
      // 
      this.imageSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.imageSizeLabel.AutoSize = true;
      this.imageSizeLabel.Location = new System.Drawing.Point(16, 710);
      this.imageSizeLabel.Name = "imageSizeLabel";
      this.imageSizeLabel.Size = new System.Drawing.Size(65, 12);
      this.imageSizeLabel.TabIndex = 10;
      this.imageSizeLabel.Text = "이미지크기";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1525, 816);
      this.Controls.Add(this.imageSizeLabel);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.imageGroupBox);
      this.Controls.Add(this.fileTextBox);
      this.Controls.Add(this.prevButton);
      this.Controls.Add(this.nextButton);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainForm";
      this.Text = "LowfiWeedout";
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
      this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.form_MouseWheel);
      this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.imageGroupBox.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox targetFolderTextBox;
    private System.Windows.Forms.Button targetFolderButton;
    private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label fileCountLabel;
    private System.Windows.Forms.Label totalFolderCountLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button prevButton;
    private System.Windows.Forms.TextBox fileTextBox;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Button selectButton;
    private System.Windows.Forms.TextBox fileNumberTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox imageGroupBox;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox faceTextBox;
    private System.Windows.Forms.CheckBox autoFaceCheckBox;
    private System.Windows.Forms.Button sizeDownButton;
    private System.Windows.Forms.Button sizeUpButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Label imageSizeLabel;
  }
}

