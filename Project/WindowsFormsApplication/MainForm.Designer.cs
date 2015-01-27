namespace WindowsFormsApplication
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._button = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(37, 37);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 23);
            this._button.TabIndex = 0;
            this._button.Text = "ボタン";
            this._button.UseVisualStyleBackColor = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(12, 12);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(100, 19);
            this._textBox.TabIndex = 1;
            this._textBox.Validating += new System.ComponentModel.CancelEventHandler(this._textBox_Validating);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 83);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TextBox _textBox;
    }
}

