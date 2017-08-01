﻿using System;
using System.Windows.Forms;
using Yushen.WebService.KessClient;
using NLog;
using System.Threading.Tasks;

namespace 金证统一账户测试账户生成器
{
    public partial class Main : Form
    {
        private Kess kess;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        ResultForm resultForm = new ResultForm();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultForm.Show();
            try
            {
                // 建立WebService连接
                if (kess == null)
                {
                    kess = new Kess(operatorId.Text, password.Text, "");
                }

                // 异步方式调用WebService查询
                Task task = Task.Run(()=>
                {
                    this.Invoke((MethodInvoker)(()=> {
                        resultForm.Append(kess.getSingleCommonParamValue(userCode.Text));
                    }));
                });
            }
            catch (Exception ex)
            {
                resultForm.Append(ex.Message);
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void 新开随机账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
