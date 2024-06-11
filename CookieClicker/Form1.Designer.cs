﻿using System.Drawing;
using System.Windows.Forms;

namespace CookieClicker
{
    partial class Form1
    {
   
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeCookiePerSecond = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiveRobots = new System.Windows.Forms.Button();
            this.btnFiveGrandmas = new System.Windows.Forms.Button();
            this.btnFiveFinger = new System.Windows.Forms.Button();
            this.lbPlusCookie_1 = new System.Windows.Forms.Label();
            this.pbCookie = new System.Windows.Forms.PictureBox();
            this.btnBuyRobot = new System.Windows.Forms.Button();
            this.lbRobots = new System.Windows.Forms.Label();
            this.btnBuyGrandma = new System.Windows.Forms.Button();
            this.lbGrandmas = new System.Windows.Forms.Label();
            this.btnBuyFinger = new System.Windows.Forms.Button();
            this.lbFingers = new System.Windows.Forms.Label();
            this.lbCPS = new System.Windows.Forms.Label();
            this.lbCookies = new System.Windows.Forms.Label();
            this.timeLabelDisappear = new System.Windows.Forms.Timer(this.components);
            this.timerFall = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button
            {
                UseVisualStyleBackColor = true
            };
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookie)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
          
            this.timeCookiePerSecond.Interval = 1000;
            this.timeCookiePerSecond.Tick += new System.EventHandler(this.timeCookiePerSecond_Tick);
          
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Location = new System.Drawing.Point(-11, -33);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(840, 500);
            this.tabControl.TabIndex = 3;
        
            this.tabGame.Controls.Add(this.panel1);
            this.tabGame.Location = new System.Drawing.Point(4, 25);
            this.tabGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGame.Size = new System.Drawing.Size(832, 471);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Игра";
            this.tabGame.UseVisualStyleBackColor = true;
            this.tabGame.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
           
            this.panel1.Controls.Add(this.btnFiveRobots);
            this.panel1.Controls.Add(this.btnFiveGrandmas);
            this.panel1.Controls.Add(this.btnFiveFinger);
            this.panel1.Controls.Add(this.lbPlusCookie_1);
            this.panel1.Controls.Add(this.pbCookie);
            this.panel1.Controls.Add(this.btnBuyRobot);
            this.panel1.Controls.Add(this.lbRobots);
            this.panel1.Controls.Add(this.btnBuyGrandma);
            this.panel1.Controls.Add(this.lbGrandmas);
            this.panel1.Controls.Add(this.btnBuyFinger);
            this.panel1.Controls.Add(this.lbFingers);
            this.panel1.Controls.Add(this.lbCPS);
            this.panel1.Controls.Add(this.lbCookies);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 471);
            this.panel1.TabIndex = 0;
        
            this.btnFiveRobots.Location = new System.Drawing.Point(607, 338);
            this.btnFiveRobots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiveRobots.Name = "btnFiveRobots";
            this.btnFiveRobots.Size = new System.Drawing.Size(165, 44);
            this.btnFiveRobots.TabIndex = 25;
            this.btnFiveRobots.Text = "Пять роботов = 1000";
            this.btnFiveRobots.UseVisualStyleBackColor = true;
            this.btnFiveRobots.Click += new System.EventHandler(this.BtnFiveRobots_Click);
         
            this.btnFiveGrandmas.Location = new System.Drawing.Point(607, 222);
            this.btnFiveGrandmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiveGrandmas.Name = "btnFiveGrandmas";
            this.btnFiveGrandmas.Size = new System.Drawing.Size(165, 47);
            this.btnFiveGrandmas.TabIndex = 24;
            this.btnFiveGrandmas.Text = "Пять бабулек = 250";
            this.btnFiveGrandmas.UseVisualStyleBackColor = true;
            this.btnFiveGrandmas.Click += new System.EventHandler(this.BtnFiveGrandmas_Click);
         
            this.btnFiveFinger.Location = new System.Drawing.Point(607, 100);
            this.btnFiveFinger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiveFinger.Name = "btnFiveFinger";
            this.btnFiveFinger.Size = new System.Drawing.Size(165, 53);
            this.btnFiveFinger.TabIndex = 23;
            this.btnFiveFinger.Text = "Пять пальцев = 50";
            this.btnFiveFinger.UseVisualStyleBackColor = true;
            this.btnFiveFinger.Click += new System.EventHandler(this.BtnFiveFingers_Click);
         
            this.lbPlusCookie_1.AutoSize = true;
            this.lbPlusCookie_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlusCookie_1.Location = new System.Drawing.Point(95, 197);
            this.lbPlusCookie_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlusCookie_1.Name = "lbPlusCookie_1";
            this.lbPlusCookie_1.Size = new System.Drawing.Size(90, 18);
            this.lbPlusCookie_1.TabIndex = 21;
            this.lbPlusCookie_1.Text = "+1 Печенька!";
            this.lbPlusCookie_1.Visible = false;
            this.lbPlusCookie_1.BackColor = Color.Transparent;
          
            this.pbCookie.Location = new System.Drawing.Point(75, 169);
            this.pbCookie.Margin = new System.Windows.Forms.Padding(4);
            this.pbCookie.Name = "pbCookie";
            this.pbCookie.Size = new System.Drawing.Size(247, 214);
            this.pbCookie.TabIndex = 22;
            this.pbCookie.TabStop = false;
            this.pbCookie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCookie_MouseDown);
            this.pbCookie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCookie_MouseUp);
         
            this.btnBuyRobot.Location = new System.Drawing.Point(421, 338);
            this.btnBuyRobot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyRobot.Name = "btnBuyRobot";
            this.btnBuyRobot.Size = new System.Drawing.Size(167, 44);
            this.btnBuyRobot.TabIndex = 20;
            this.btnBuyRobot.Text = "Робот = 200";
            this.btnBuyRobot.UseVisualStyleBackColor = true;
            this.btnBuyRobot.Click += new System.EventHandler(this.btnBuyRobot_Click);
          
            this.lbRobots.AutoSize = true;
            this.lbRobots.BackColor = System.Drawing.Color.White;
            this.lbRobots.Location = new System.Drawing.Point(419, 318);
            this.lbRobots.Name = "lbRobots";
            this.lbRobots.Size = new System.Drawing.Size(69, 17);
            this.lbRobots.TabIndex = 19;
            this.lbRobots.Text = "Роботы: 0";
            this.lbRobots.BackColor = Color.Transparent;
         
            this.btnBuyGrandma.Location = new System.Drawing.Point(421, 222);
            this.btnBuyGrandma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyGrandma.Name = "btnBuyGrandma";
            this.btnBuyGrandma.Size = new System.Drawing.Size(167, 47);
            this.btnBuyGrandma.TabIndex = 18;
            this.btnBuyGrandma.Text = "Бабулька = 50";
            this.btnBuyGrandma.UseVisualStyleBackColor = true;
            this.btnBuyGrandma.Click += new System.EventHandler(this.btnBuyGrandma_Click);
          
            this.lbGrandmas.AutoSize = true;
            this.lbGrandmas.BackColor = System.Drawing.Color.White;
            this.lbGrandmas.Location = new System.Drawing.Point(419, 202);
            this.lbGrandmas.Name = "lbGrandmas";
            this.lbGrandmas.Size = new System.Drawing.Size(90, 17);
            this.lbGrandmas.TabIndex = 17;
            this.lbGrandmas.Text = "Бабульки: 0";
            this.lbGrandmas.BackColor = Color.Transparent;
           
            this.btnBuyFinger.Location = new System.Drawing.Point(421, 100);
            this.btnBuyFinger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyFinger.Name = "btnBuyFinger";
            this.btnBuyFinger.Size = new System.Drawing.Size(167, 53);
            this.btnBuyFinger.TabIndex = 16;
            this.btnBuyFinger.Text = "Палец = 10";
            this.btnBuyFinger.UseVisualStyleBackColor = true;
            this.btnBuyFinger.Click += new System.EventHandler(this.btnBuyFinger_Click);
           
            this.lbFingers.AutoSize = true;
            this.lbFingers.BackColor = System.Drawing.Color.White;
            this.lbFingers.Location = new System.Drawing.Point(419, 80);
            this.lbFingers.Name = "lbFingers";
            this.lbFingers.Size = new System.Drawing.Size(71, 17);
            this.lbFingers.TabIndex = 15;
            this.lbFingers.Text = "Пальцы: 0";
            this.lbFingers.BackColor = Color.Transparent;
       
            this.lbCPS.AutoSize = true;
            this.lbCPS.BackColor = System.Drawing.Color.White;
            this.lbCPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPS.Location = new System.Drawing.Point(71, 116);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(201, 20);
            this.lbCPS.TabIndex = 14;
            this.lbCPS.Text = "Печеньки в секунду: 0";
            this.lbCPS.BackColor = Color.Transparent;
        
            this.lbCookies.AutoSize = true;
            this.lbCookies.BackColor = System.Drawing.Color.White;
            this.lbCookies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCookies.Location = new System.Drawing.Point(71, 82);
            this.lbCookies.Name = "lbCookies";
            this.lbCookies.Size = new System.Drawing.Size(98, 20);
            this.lbCookies.TabIndex = 13;
            this.lbCookies.Text = "Печеньки: 0";
            this.lbCookies.BackColor = Color.Transparent;
           
            this.timeLabelDisappear.Enabled = true;
            this.timeLabelDisappear.Interval = 350;
            this.timeLabelDisappear.Tick += new System.EventHandler(this.timeLabelDisappear_Tick);
         
            this.timerFall.Tick += new System.EventHandler(this.timerFall_Tick);
            
            this.btnStartGame.Location = new System.Drawing.Point(244, 174);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(325, 49);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начать";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            
            
            this.btnQuitGame.Location = new System.Drawing.Point(244, 252);
            this.btnQuitGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(325, 49);
            this.btnQuitGame.TabIndex = 1;
            this.btnQuitGame.Text = "Выйти";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
        
            this.tabMenu.BackColor = System.Drawing.Color.Transparent;
            this.tabMenu.Controls.Add(this.btnQuitGame);
            this.tabMenu.Controls.Add(this.btnStartGame);
            this.tabMenu.ForeColor = System.Drawing.Color.Black;
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Size = new System.Drawing.Size(832, 471);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Меню";
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 458);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Печеньки Кликер";
            this.tabControl.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookie)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeCookiePerSecond;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.Timer timeLabelDisappear;
        private System.Windows.Forms.Timer timerFall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPlusCookie_1;
        private System.Windows.Forms.PictureBox pbCookie;
        private System.Windows.Forms.Button btnBuyRobot;
        private System.Windows.Forms.Label lbRobots;
        private System.Windows.Forms.Button btnBuyGrandma;
        private System.Windows.Forms.Label lbGrandmas;
        private System.Windows.Forms.Button btnBuyFinger;
        private System.Windows.Forms.Label lbFingers;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Label lbCookies;
        private System.Windows.Forms.Button btnFiveRobots;
        private System.Windows.Forms.Button btnFiveGrandmas;
        private System.Windows.Forms.Button btnFiveFinger;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnStartGame;
    }
}

