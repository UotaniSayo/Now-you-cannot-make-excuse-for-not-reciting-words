namespace CStest
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.txtTitle = new System.Windows.Forms.Label();
            this.fillinAmount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFvrt = new System.Windows.Forms.Button();
            this.txtTango = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHira = new System.Windows.Forms.Button();
            this.btnXplain = new System.Windows.Forms.Button();
            this.txtHira = new System.Windows.Forms.Label();
            this.txtXplain = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(162, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(104, 16);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "本次单词数量";
            // 
            // fillinAmount
            // 
            this.fillinAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fillinAmount.Location = new System.Drawing.Point(272, 48);
            this.fillinAmount.Name = "fillinAmount";
            this.fillinAmount.Size = new System.Drawing.Size(100, 26);
            this.fillinAmount.TabIndex = 1;
            this.fillinAmount.Text = "200";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(252, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFvrt
            // 
            this.btnFvrt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFvrt.Location = new System.Drawing.Point(252, 311);
            this.btnFvrt.Name = "btnFvrt";
            this.btnFvrt.Size = new System.Drawing.Size(75, 35);
            this.btnFvrt.TabIndex = 3;
            this.btnFvrt.Text = "生词";
            this.btnFvrt.UseVisualStyleBackColor = true;
            // 
            // txtTango
            // 
            this.txtTango.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTango.Location = new System.Drawing.Point(209, 176);
            this.txtTango.Name = "txtTango";
            this.txtTango.Size = new System.Drawing.Size(150, 23);
            this.txtTango.TabIndex = 4;
            this.txtTango.Text = "単語";
            this.txtTango.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTango.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(99, 128);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(80, 35);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "前一个";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(409, 128);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "后一个";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHira
            // 
            this.btnHira.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHira.Location = new System.Drawing.Point(79, 263);
            this.btnHira.Name = "btnHira";
            this.btnHira.Size = new System.Drawing.Size(100, 35);
            this.btnHira.TabIndex = 7;
            this.btnHira.Text = "显示读音";
            this.btnHira.UseVisualStyleBackColor = true;
            this.btnHira.Visible = false;
            this.btnHira.Click += new System.EventHandler(this.btnHira_Click);
            // 
            // btnXplain
            // 
            this.btnXplain.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXplain.Location = new System.Drawing.Point(79, 357);
            this.btnXplain.Name = "btnXplain";
            this.btnXplain.Size = new System.Drawing.Size(100, 35);
            this.btnXplain.TabIndex = 8;
            this.btnXplain.Text = "显示释义";
            this.btnXplain.UseVisualStyleBackColor = true;
            this.btnXplain.Visible = false;
            this.btnXplain.Click += new System.EventHandler(this.btnXplain_Click);
            // 
            // txtHira
            // 
            this.txtHira.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHira.Location = new System.Drawing.Point(199, 270);
            this.txtHira.Name = "txtHira";
            this.txtHira.Size = new System.Drawing.Size(150, 23);
            this.txtHira.TabIndex = 9;
            this.txtHira.Text = "発音";
            this.txtHira.Visible = false;
            // 
            // txtXplain
            // 
            this.txtXplain.AutoSize = true;
            this.txtXplain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXplain.Location = new System.Drawing.Point(199, 364);
            this.txtXplain.Name = "txtXplain";
            this.txtXplain.Size = new System.Drawing.Size(42, 21);
            this.txtXplain.TabIndex = 10;
            this.txtXplain.Text = "意味";
            this.txtXplain.Visible = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnd.Location = new System.Drawing.Point(457, 500);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 35);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtXplain);
            this.Controls.Add(this.txtHira);
            this.Controls.Add(this.btnXplain);
            this.Controls.Add(this.btnHira);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtTango);
            this.Controls.Add(this.btnFvrt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.fillinAmount);
            this.Controls.Add(this.txtTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "辣鸡VB迟早药丸";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox fillinAmount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFvrt;
        private System.Windows.Forms.Label txtTango;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHira;
        private System.Windows.Forms.Button btnXplain;
        private System.Windows.Forms.Label txtHira;
        private System.Windows.Forms.Label txtXplain;
        private System.Windows.Forms.Button btnEnd;
    }
}

