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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.新开账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新开创业板转签测试账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据字典查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageGetDict = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dictName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.zip_code = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnOpenYMT = new System.Windows.Forms.Button();
            this.btnOpenCYB = new System.Windows.Forms.Button();
            this.tbxYMTCode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnOpenAccountByOneClick = new System.Windows.Forms.Button();
            this.tbxSZAcct = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxSHAcct = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxCuacct = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRegisterStockAccount = new System.Windows.Forms.Button();
            this.btnOpenStockAccount = new System.Windows.Forms.Button();
            this.btnQueryStockAccount = new System.Windows.Forms.Button();
            this.btnBankSign = new System.Windows.Forms.Button();
            this.btnSubmitRiskTest = new System.Windows.Forms.Button();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.btnOpenCuacct = new System.Windows.Forms.Button();
            this.risk_level = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bank_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_exp_date = new System.Windows.Forms.DateTimePicker();
            this.id_beg_date = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mobile_tel = new System.Windows.Forms.TextBox();
            this.id_addr = new System.Windows.Forms.TextBox();
            this.id_iss_agcy = new System.Windows.Forms.TextBox();
            this.id_code = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.tbxCustCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenUserCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nationality = new System.Windows.Forms.ComboBox();
            this.occu_type = new System.Windows.Forms.ComboBox();
            this.education = new System.Windows.Forms.ComboBox();
            this.citizenship = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.tabPageGetDict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(950, 25);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新开账户ToolStripMenuItem,
            this.新开创业板转签测试账户ToolStripMenuItem,
            this.数据字典查询ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem2.Text = "功能";
            // 
            // 新开账户ToolStripMenuItem
            // 
            this.新开账户ToolStripMenuItem.Name = "新开账户ToolStripMenuItem";
            this.新开账户ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.新开账户ToolStripMenuItem.Text = "新开账户";
            this.新开账户ToolStripMenuItem.Click += new System.EventHandler(this.新开随机账户ToolStripMenuItem_Click);
            // 
            // 新开创业板转签测试账户ToolStripMenuItem
            // 
            this.新开创业板转签测试账户ToolStripMenuItem.Name = "新开创业板转签测试账户ToolStripMenuItem";
            this.新开创业板转签测试账户ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.新开创业板转签测试账户ToolStripMenuItem.Text = "新开创业板转签测试账户";
            // 
            // 数据字典查询ToolStripMenuItem
            // 
            this.数据字典查询ToolStripMenuItem.Name = "数据字典查询ToolStripMenuItem";
            this.数据字典查询ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.数据字典查询ToolStripMenuItem.Text = "数据字典查询";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // tabPageGetDict
            // 
            this.tabPageGetDict.Controls.Add(this.dataGridView1);
            this.tabPageGetDict.Controls.Add(this.button2);
            this.tabPageGetDict.Controls.Add(this.dictName);
            this.tabPageGetDict.Controls.Add(this.label14);
            this.tabPageGetDict.Location = new System.Drawing.Point(4, 22);
            this.tabPageGetDict.Name = "tabPageGetDict";
            this.tabPageGetDict.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetDict.Size = new System.Drawing.Size(918, 436);
            this.tabPageGetDict.TabIndex = 1;
            this.tabPageGetDict.Text = "数据字典查询";
            this.tabPageGetDict.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(905, 397);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dictName
            // 
            this.dictName.Location = new System.Drawing.Point(79, 6);
            this.dictName.Name = "dictName";
            this.dictName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dictName.Size = new System.Drawing.Size(278, 21);
            this.dictName.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "字典项：";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sex);
            this.tabPage1.Controls.Add(this.citizenship);
            this.tabPage1.Controls.Add(this.education);
            this.tabPage1.Controls.Add(this.occu_type);
            this.tabPage1.Controls.Add(this.nationality);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.zip_code);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.btnOpenYMT);
            this.tabPage1.Controls.Add(this.btnOpenCYB);
            this.tabPage1.Controls.Add(this.tbxYMTCode);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.btnOpenAccountByOneClick);
            this.tabPage1.Controls.Add(this.tbxSZAcct);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.tbxSHAcct);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.tbxCuacct);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btnRegisterStockAccount);
            this.tabPage1.Controls.Add(this.btnOpenStockAccount);
            this.tabPage1.Controls.Add(this.btnQueryStockAccount);
            this.tabPage1.Controls.Add(this.btnBankSign);
            this.tabPage1.Controls.Add(this.btnSubmitRiskTest);
            this.tabPage1.Controls.Add(this.btnSetPassword);
            this.tabPage1.Controls.Add(this.btnOpenCuacct);
            this.tabPage1.Controls.Add(this.risk_level);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.bank_code);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.id_exp_date);
            this.tabPage1.Controls.Add(this.id_beg_date);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.mobile_tel);
            this.tabPage1.Controls.Add(this.id_addr);
            this.tabPage1.Controls.Add(this.id_iss_agcy);
            this.tabPage1.Controls.Add(this.id_code);
            this.tabPage1.Controls.Add(this.user_name);
            this.tabPage1.Controls.Add(this.tbxCustCode);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnOpenUserCode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新开账户";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(812, 37);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 63;
            this.btnLogin.Text = "操作员登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(592, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 62;
            this.label22.Text = "性别：";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zip_code
            // 
            this.zip_code.Location = new System.Drawing.Point(266, 173);
            this.zip_code.Name = "zip_code";
            this.zip_code.Size = new System.Drawing.Size(100, 21);
            this.zip_code.TabIndex = 60;
            this.zip_code.Text = "230000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(219, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 59;
            this.label21.Text = "邮编：";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenYMT
            // 
            this.btnOpenYMT.Location = new System.Drawing.Point(653, 204);
            this.btnOpenYMT.Name = "btnOpenYMT";
            this.btnOpenYMT.Size = new System.Drawing.Size(86, 23);
            this.btnOpenYMT.TabIndex = 58;
            this.btnOpenYMT.Text = "开一码通";
            this.btnOpenYMT.UseVisualStyleBackColor = true;
            this.btnOpenYMT.Click += new System.EventHandler(this.btnOpenYMT_Click);
            // 
            // btnOpenCYB
            // 
            this.btnOpenCYB.Location = new System.Drawing.Point(467, 241);
            this.btnOpenCYB.Name = "btnOpenCYB";
            this.btnOpenCYB.Size = new System.Drawing.Size(88, 23);
            this.btnOpenCYB.TabIndex = 57;
            this.btnOpenCYB.Text = "签署创业板";
            this.btnOpenCYB.UseVisualStyleBackColor = true;
            this.btnOpenCYB.Click += new System.EventHandler(this.btnOpenCYB_Click);
            // 
            // tbxYMTCode
            // 
            this.tbxYMTCode.Location = new System.Drawing.Point(290, 243);
            this.tbxYMTCode.Name = "tbxYMTCode";
            this.tbxYMTCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxYMTCode.Size = new System.Drawing.Size(100, 21);
            this.tbxYMTCode.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(231, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 55;
            this.label20.Text = "一码通：";
            // 
            // btnOpenAccountByOneClick
            // 
            this.btnOpenAccountByOneClick.Location = new System.Drawing.Point(13, 204);
            this.btnOpenAccountByOneClick.Name = "btnOpenAccountByOneClick";
            this.btnOpenAccountByOneClick.Size = new System.Drawing.Size(86, 23);
            this.btnOpenAccountByOneClick.TabIndex = 54;
            this.btnOpenAccountByOneClick.Text = "一站式开户";
            this.btnOpenAccountByOneClick.UseVisualStyleBackColor = true;
            this.btnOpenAccountByOneClick.Click += new System.EventHandler(this.btnOpenAccountByOneClick_Click);
            // 
            // tbxSZAcct
            // 
            this.tbxSZAcct.Location = new System.Drawing.Point(290, 297);
            this.tbxSZAcct.Name = "tbxSZAcct";
            this.tbxSZAcct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSZAcct.Size = new System.Drawing.Size(100, 21);
            this.tbxSZAcct.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 52;
            this.label19.Text = "深圳A股：";
            // 
            // tbxSHAcct
            // 
            this.tbxSHAcct.Location = new System.Drawing.Point(290, 270);
            this.tbxSHAcct.Name = "tbxSHAcct";
            this.tbxSHAcct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSHAcct.Size = new System.Drawing.Size(100, 21);
            this.tbxSHAcct.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(225, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 50;
            this.label18.Text = "上海A股：";
            // 
            // tbxCuacct
            // 
            this.tbxCuacct.Location = new System.Drawing.Point(105, 272);
            this.tbxCuacct.Name = "tbxCuacct";
            this.tbxCuacct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCuacct.Size = new System.Drawing.Size(100, 21);
            this.tbxCuacct.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 48;
            this.label17.Text = "资金账号：";
            // 
            // btnRegisterStockAccount
            // 
            this.btnRegisterStockAccount.Location = new System.Drawing.Point(826, 204);
            this.btnRegisterStockAccount.Name = "btnRegisterStockAccount";
            this.btnRegisterStockAccount.Size = new System.Drawing.Size(86, 23);
            this.btnRegisterStockAccount.TabIndex = 47;
            this.btnRegisterStockAccount.Text = "加挂股东账户";
            this.btnRegisterStockAccount.UseVisualStyleBackColor = true;
            this.btnRegisterStockAccount.Click += new System.EventHandler(this.btnRegisterStockAccount_Click);
            // 
            // btnOpenStockAccount
            // 
            this.btnOpenStockAccount.Location = new System.Drawing.Point(745, 204);
            this.btnOpenStockAccount.Name = "btnOpenStockAccount";
            this.btnOpenStockAccount.Size = new System.Drawing.Size(75, 23);
            this.btnOpenStockAccount.TabIndex = 46;
            this.btnOpenStockAccount.Text = "新开股东户";
            this.btnOpenStockAccount.UseVisualStyleBackColor = true;
            this.btnOpenStockAccount.Click += new System.EventHandler(this.btnOpenStockAccount_Click);
            // 
            // btnQueryStockAccount
            // 
            this.btnQueryStockAccount.Location = new System.Drawing.Point(561, 204);
            this.btnQueryStockAccount.Name = "btnQueryStockAccount";
            this.btnQueryStockAccount.Size = new System.Drawing.Size(86, 23);
            this.btnQueryStockAccount.TabIndex = 45;
            this.btnQueryStockAccount.Text = "股东账户查询";
            this.btnQueryStockAccount.UseVisualStyleBackColor = true;
            this.btnQueryStockAccount.Click += new System.EventHandler(this.btnQueryStockAccount_Click);
            // 
            // btnBankSign
            // 
            this.btnBankSign.Enabled = false;
            this.btnBankSign.Location = new System.Drawing.Point(467, 204);
            this.btnBankSign.Name = "btnBankSign";
            this.btnBankSign.Size = new System.Drawing.Size(88, 23);
            this.btnBankSign.TabIndex = 43;
            this.btnBankSign.Text = "三方存管签约";
            this.btnBankSign.UseVisualStyleBackColor = true;
            this.btnBankSign.Click += new System.EventHandler(this.btnBankSign_Click);
            // 
            // btnSubmitRiskTest
            // 
            this.btnSubmitRiskTest.Location = new System.Drawing.Point(371, 204);
            this.btnSubmitRiskTest.Name = "btnSubmitRiskTest";
            this.btnSubmitRiskTest.Size = new System.Drawing.Size(90, 23);
            this.btnSubmitRiskTest.TabIndex = 42;
            this.btnSubmitRiskTest.Text = "提交风险测评";
            this.btnSubmitRiskTest.UseVisualStyleBackColor = true;
            this.btnSubmitRiskTest.Click += new System.EventHandler(this.btnSubmitRiskTest_Click);
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(290, 204);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSetPassword.TabIndex = 41;
            this.btnSetPassword.Text = "设置密码";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // btnOpenCuacct
            // 
            this.btnOpenCuacct.Location = new System.Drawing.Point(209, 204);
            this.btnOpenCuacct.Name = "btnOpenCuacct";
            this.btnOpenCuacct.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCuacct.TabIndex = 40;
            this.btnOpenCuacct.Text = "开资金账号";
            this.btnOpenCuacct.UseVisualStyleBackColor = true;
            this.btnOpenCuacct.Click += new System.EventHandler(this.btnOpenCuacct_Click);
            // 
            // risk_level
            // 
            this.risk_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.risk_level.FormattingEnabled = true;
            this.risk_level.Location = new System.Drawing.Point(458, 66);
            this.risk_level.Name = "risk_level";
            this.risk_level.Size = new System.Drawing.Size(100, 20);
            this.risk_level.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 38;
            this.label16.Text = "风测级别：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 36;
            this.label15.Text = "存管银行：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bank_code
            // 
            this.bank_code.Location = new System.Drawing.Point(458, 39);
            this.bank_code.Name = "bank_code";
            this.bank_code.Size = new System.Drawing.Size(100, 21);
            this.bank_code.TabIndex = 35;
            this.bank_code.Text = "5900";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "交易密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(458, 12);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 33;
            this.password.Text = "111111";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(812, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "重新生成客户";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_exp_date
            // 
            this.id_exp_date.CustomFormat = "yyyyMMdd";
            this.id_exp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.id_exp_date.Location = new System.Drawing.Point(105, 120);
            this.id_exp_date.Name = "id_exp_date";
            this.id_exp_date.Size = new System.Drawing.Size(200, 21);
            this.id_exp_date.TabIndex = 31;
            this.id_exp_date.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // id_beg_date
            // 
            this.id_beg_date.CustomFormat = "yyyyMMdd";
            this.id_beg_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.id_beg_date.Location = new System.Drawing.Point(105, 93);
            this.id_beg_date.Name = "id_beg_date";
            this.id_beg_date.Size = new System.Drawing.Size(200, 21);
            this.id_beg_date.TabIndex = 30;
            this.id_beg_date.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "证件开始日期：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "移动电话：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mobile_tel
            // 
            this.mobile_tel.Location = new System.Drawing.Point(105, 173);
            this.mobile_tel.Name = "mobile_tel";
            this.mobile_tel.Size = new System.Drawing.Size(100, 21);
            this.mobile_tel.TabIndex = 26;
            this.mobile_tel.Text = "18655958868";
            // 
            // id_addr
            // 
            this.id_addr.Location = new System.Drawing.Point(105, 147);
            this.id_addr.Name = "id_addr";
            this.id_addr.Size = new System.Drawing.Size(261, 21);
            this.id_addr.TabIndex = 16;
            this.id_addr.Text = "安徽合肥蜀山区梅山路18号国际金融中心A座";
            // 
            // id_iss_agcy
            // 
            this.id_iss_agcy.Location = new System.Drawing.Point(105, 66);
            this.id_iss_agcy.Name = "id_iss_agcy";
            this.id_iss_agcy.Size = new System.Drawing.Size(261, 21);
            this.id_iss_agcy.TabIndex = 12;
            this.id_iss_agcy.Text = "合肥市公安局蜀山分局";
            // 
            // id_code
            // 
            this.id_code.Location = new System.Drawing.Point(105, 39);
            this.id_code.Name = "id_code";
            this.id_code.Size = new System.Drawing.Size(261, 21);
            this.id_code.TabIndex = 10;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(105, 12);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(261, 21);
            this.user_name.TabIndex = 8;
            // 
            // tbxCustCode
            // 
            this.tbxCustCode.Location = new System.Drawing.Point(105, 245);
            this.tbxCustCode.Name = "tbxCustCode";
            this.tbxCustCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCustCode.Size = new System.Drawing.Size(100, 21);
            this.tbxCustCode.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "证件地址：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "学历：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "职业：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "民族：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "国籍：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "证件有效日期：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "发证机关：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "证件号码：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "客户名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenUserCode
            // 
            this.btnOpenUserCode.Location = new System.Drawing.Point(128, 204);
            this.btnOpenUserCode.Name = "btnOpenUserCode";
            this.btnOpenUserCode.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUserCode.TabIndex = 0;
            this.btnOpenUserCode.Text = "开客户号";
            this.btnOpenUserCode.UseVisualStyleBackColor = true;
            this.btnOpenUserCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "客户号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageGetDict);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 462);
            this.tabControl1.TabIndex = 9;
            // 
            // nationality
            // 
            this.nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationality.FormattingEnabled = true;
            this.nationality.Location = new System.Drawing.Point(458, 92);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(100, 20);
            this.nationality.TabIndex = 64;
            // 
            // occu_type
            // 
            this.occu_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occu_type.FormattingEnabled = true;
            this.occu_type.Location = new System.Drawing.Point(458, 119);
            this.occu_type.Name = "occu_type";
            this.occu_type.Size = new System.Drawing.Size(100, 20);
            this.occu_type.TabIndex = 65;
            // 
            // education
            // 
            this.education.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.education.FormattingEnabled = true;
            this.education.Location = new System.Drawing.Point(458, 145);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(100, 20);
            this.education.TabIndex = 66;
            // 
            // citizenship
            // 
            this.citizenship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citizenship.FormattingEnabled = true;
            this.citizenship.Location = new System.Drawing.Point(458, 173);
            this.citizenship.Name = "citizenship";
            this.citizenship.Size = new System.Drawing.Size(100, 20);
            this.citizenship.TabIndex = 67;
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Location = new System.Drawing.Point(639, 12);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 20);
            this.sex.TabIndex = 68;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "金证统一账户测试账户生成器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPageGetDict.ResumeLayout(false);
            this.tabPageGetDict.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 新开账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新开创业板转签测试账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据字典查询ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageGetDict;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dictName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker id_exp_date;
        private System.Windows.Forms.DateTimePicker id_beg_date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mobile_tel;
        private System.Windows.Forms.TextBox id_addr;
        private System.Windows.Forms.TextBox id_iss_agcy;
        private System.Windows.Forms.TextBox id_code;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox tbxCustCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenUserCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bank_code;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox risk_level;
        private System.Windows.Forms.Button btnOpenStockAccount;
        private System.Windows.Forms.Button btnQueryStockAccount;
        private System.Windows.Forms.Button btnBankSign;
        private System.Windows.Forms.Button btnSubmitRiskTest;
        private System.Windows.Forms.Button btnSetPassword;
        private System.Windows.Forms.Button btnOpenCuacct;
        private System.Windows.Forms.Button btnRegisterStockAccount;
        private System.Windows.Forms.TextBox tbxCuacct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxSZAcct;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxSHAcct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnOpenAccountByOneClick;
        private System.Windows.Forms.TextBox tbxYMTCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnOpenCYB;
        private System.Windows.Forms.Button btnOpenYMT;
        private System.Windows.Forms.TextBox zip_code;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox citizenship;
        private System.Windows.Forms.ComboBox education;
        private System.Windows.Forms.ComboBox occu_type;
        private System.Windows.Forms.ComboBox nationality;
        private System.Windows.Forms.ComboBox sex;
    }
}

