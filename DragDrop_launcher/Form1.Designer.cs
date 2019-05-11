namespace DragDrop_launcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3_folderpath = new System.Windows.Forms.TextBox();
            this.label1_drop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_parameters = new System.Windows.Forms.TextBox();
            this.button1_execute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_drop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "起動するアプリの場所(パス)";
            // 
            // textBox3_folderpath
            // 
            this.textBox3_folderpath.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3_folderpath.Location = new System.Drawing.Point(12, 30);
            this.textBox3_folderpath.Multiline = true;
            this.textBox3_folderpath.Name = "textBox3_folderpath";
            this.textBox3_folderpath.Size = new System.Drawing.Size(313, 77);
            this.textBox3_folderpath.TabIndex = 9;
            // 
            // label1_drop
            // 
            this.label1_drop.AllowDrop = true;
            this.label1_drop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_drop.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1_drop.Location = new System.Drawing.Point(12, 199);
            this.label1_drop.Name = "label1_drop";
            this.label1_drop.Size = new System.Drawing.Size(313, 69);
            this.label1_drop.TabIndex = 11;
            this.label1_drop.Text = "Drop it!";
            this.label1_drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "追加で付与するパラメーター(Default:empty)";
            // 
            // textBox1_parameters
            // 
            this.textBox1_parameters.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1_parameters.Location = new System.Drawing.Point(12, 131);
            this.textBox1_parameters.Multiline = true;
            this.textBox1_parameters.Name = "textBox1_parameters";
            this.textBox1_parameters.Size = new System.Drawing.Size(313, 65);
            this.textBox1_parameters.TabIndex = 12;
            // 
            // button1_execute
            // 
            this.button1_execute.Location = new System.Drawing.Point(259, 301);
            this.button1_execute.Name = "button1_execute";
            this.button1_execute.Size = new System.Drawing.Size(66, 27);
            this.button1_execute.TabIndex = 14;
            this.button1_execute.Text = "実行";
            this.button1_execute.UseVisualStyleBackColor = true;
            this.button1_execute.Click += new System.EventHandler(this.button1_execute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "末尾に追加するパラメーター(Drop)";
            // 
            // textBox1_drop
            // 
            this.textBox1_drop.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1_drop.Location = new System.Drawing.Point(12, 296);
            this.textBox1_drop.Multiline = true;
            this.textBox1_drop.Name = "textBox1_drop";
            this.textBox1_drop.Size = new System.Drawing.Size(241, 32);
            this.textBox1_drop.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_drop);
            this.Controls.Add(this.button1_execute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_parameters);
            this.Controls.Add(this.label1_drop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3_folderpath);
            this.Name = "Form1";
            this.Text = "DragDrop_launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3_folderpath;
        private System.Windows.Forms.Label label1_drop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_parameters;
        private System.Windows.Forms.Button button1_execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_drop;
    }
}

