﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace 金证统一账户测试账户生成器
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.operatorId = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Location = new System.Drawing.Point(12, 41);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoBox.Size = new System.Drawing.Size(1037, 592);
            this.infoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "操作员：";
            // 
            // operatorId
            // 
            this.operatorId.Location = new System.Drawing.Point(71, 12);
            this.operatorId.Name = "operatorId";
            this.operatorId.Size = new System.Drawing.Size(100, 21);
            this.operatorId.TabIndex = 3;
            this.operatorId.Text = "90019";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(191, 17);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(41, 12);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "密码：";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(238, 12);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 5;
            this.password.Text = "888888";
            // 
            // userCode
            // 
            this.userCode.Location = new System.Drawing.Point(409, 12);
            this.userCode.Name = "userCode";
            this.userCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userCode.Size = new System.Drawing.Size(100, 21);
            this.userCode.TabIndex = 7;
            this.userCode.Text = "201042622";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "客户号：";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 645);
            this.Controls.Add(this.userCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.operatorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "金证统一账户测试账户生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox operatorId;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userCode;
        private System.Windows.Forms.Label label3;
    }
}

