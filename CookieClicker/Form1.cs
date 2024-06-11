using System;
using System.Drawing;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        CookieGame cookieGame { get; set; }

        private FallDoc fallDoc;
        private int generateFall;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            fallDoc = new FallDoc();
            generateFall = 0;
            random = new Random();

            panel1.ForeColor = Color.White;
            this.tabMenu.BackColor = Color.FromArgb(89,	53,	31);


            this.DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CreateCookie();

        }


        public void CreateCookie()
        {
            Cookie cookie = new Cookie();
            cookieGame = new CookieGame(cookie);
            cookieGame.StartGame();
            Invalidate(true);

            pbCookie.Image = Properties.Resources.cookie1_transparent_small;
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;

            lbPlusCookie_1.Parent = pbCookie;
            lbPlusCookie_1.BackColor = Color.Transparent;
        }

        void timerFall_Tick(object sender, EventArgs e)
        {
            int module = 10;

            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 2)
                module = 8;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 5)
                module = 5;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 7)
                module = 3;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 10)
                module = 2;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 30)
                module = 1;
            if (generateFall % module == 0)
            {
                int x = random.Next(2 * Fall.RADIUS, Width - (Fall.RADIUS * 2));
                int y = -Fall.RADIUS;
                fallDoc.AddFall(new Point(x, y));
            }

            ++generateFall;
            fallDoc.Move(Width);
            Invalidate(true);
        }


        public void ClickCookie()
        {
        
            cookieGame.ClickCookie();

         
            UpdateCookiesLabel();
            UpdatePlusCookieLabel();


            CheckEnabled();
        }

        public void ClickCookieDown()
        {
         
            pbCookie.SizeMode = PictureBoxSizeMode.Zoom;
        }


        public void ClickCookieUp()
        {
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickCookie();
        }

        public Point GeneratePointForLabel()
        {
            // todo: Show +1 Cookie! toast notification
            Rectangle cookieRectangle = pbCookie.Bounds;
            lbPlusCookie_1.Visible = false;

            Random rnd = new Random();

            int rndX = rnd.Next(0, cookieRectangle.Width - 70);
            int rndY = rnd.Next(0, cookieRectangle.Height - 40);

            return new Point(rndX, rndY);
        }

        public void UpdatePlusCookieLabel()
        {
            Point randomPt = GeneratePointForLabel();


            lbPlusCookie_1.Location = randomPt;
            lbPlusCookie_1.Visible = true;

        }

      
        public void UpdateFingerLabel()
        {
            this.lbFingers.Text = String.Format("Пальцы: {0}", CookieGame.FingersCount);
            this.btnBuyFinger.Text = String.Format("Палец = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Finger_Cost), PowerUpRates.Finger_CPS);
        }

   
        public void UpdateGrandmaLabel()
        {
            this.lbGrandmas.Text = String.Format("Бабульки: {0}", CookieGame.GrandmasCount);
            this.btnBuyGrandma.Text = String.Format("Бабулька = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Grandma_Cost), PowerUpRates.Grandma_CPS);
        }

        public void UpdateRobotLabel()
        {
            this.lbRobots.Text = String.Format("Роботы: {0}", CookieGame.RobotsCount);
            this.btnBuyRobot.Text = String.Format("Робот = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Robot_Cost), PowerUpRates.Robot_CPS);
        }


        public void updateFiveFingerButton()
        {
            this.btnFiveFinger.Text = String.Format("Пять пальцев = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Finger_Cost * 5), PowerUpRates.Finger_CPS * 5);
        }

        public void updateFiveGrandmaButton()
        {
            this.btnFiveGrandmas.Text = String.Format("Пять бабулек = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Grandma_Cost * 5), PowerUpRates.Grandma_CPS * 5);
        }
        public void updateFiveRobotButton()
        {
            this.btnFiveRobots.Text = String.Format("Пять роботов = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Robot_Cost * 5), PowerUpRates.Robot_CPS * 5);
        }

        
        public void UpdateCookiesLabel()
        {
            this.lbCookies.Text = String.Format("Печеньки: {0}", cookieGame.CookiesCount);

        }

      
        public void UpdateCPSLabel()
        {
            this.lbCPS.Text = String.Format("Печеньки в секунду: {0:0.0}", cookieGame.ClicksPerSecond);
        }

      
        public void UpdateLabels()
        {
            this.UpdateCookiesLabel();
            this.UpdateCPSLabel();
            this.UpdateFingerLabel();
            this.UpdateGrandmaLabel();
            this.UpdateRobotLabel();
            this.updateFiveFingerButton();
            this.updateFiveGrandmaButton();
            this.updateFiveRobotButton();
        }

        
        public void Start()
        {
            CheckEnabled();
            UpdateLabels();

            timeCookiePerSecond.Start();

            timerFall.Start();
            tabControl.SelectedTab = tabGame;
        }

      
        public void Quit()
        {
            this.Close();
        }

        
        public void CheckEnabled()
        {
            //fixed
            if (cookieGame.CookiesCount < PowerUpRates.Grandma_Cost)
                btnBuyGrandma.Enabled = false;
            else
                btnBuyGrandma.Enabled = true;


            if (cookieGame.CookiesCount < PowerUpRates.Finger_Cost)
                btnBuyFinger.Enabled = false;
            else
                btnBuyFinger.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Robot_Cost)
                btnBuyRobot.Enabled = false;
            else
                btnBuyRobot.Enabled = true;


            if (cookieGame.CookiesCount < PowerUpRates.Finger_Cost * 5)
                btnFiveFinger.Enabled = false;
            else
                btnFiveFinger.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Grandma_Cost * 5)
                btnFiveGrandmas.Enabled = false;
            else
                btnFiveGrandmas.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Robot_Cost * 5)
                btnFiveRobots.Enabled = false;
            else
                btnFiveRobots.Enabled = true;
        }

        private void timeCookiePerSecond_Tick(object sender, EventArgs e)
        {

            cookieGame.UpdateCookies();
            UpdateLabels();
            CheckEnabled();

        }

        public void AddFinger()
        {
            cookieGame.AddPowerUp(new Finger());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddGrandma()
        {
            cookieGame.AddPowerUp(new Grandma());
            CheckEnabled();
            UpdateLabels();
        }

        public void AddRobot()
        {
            cookieGame.AddPowerUp(new Robot());
            CheckEnabled();
            UpdateLabels();
        }

        public void AddFiveFinger()
        {
            cookieGame.AddPowerUp(new FiveFingers());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddFiveGrandma()
        {
            cookieGame.AddPowerUp(new FiveGrandmas());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddFiveRobot()
        {
            cookieGame.AddPowerUp(new FiveRobots());
            UpdateLabels();
            CheckEnabled();
        }


        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnBuyFinger_Click(object sender, EventArgs e)
        {
            AddFinger();
        }

        private void btnBuyGrandma_Click(object sender, EventArgs e)
        {
            AddGrandma();
        }

        private void btnBuyRobot_Click(object sender, EventArgs e)
        {
            AddRobot();
        }
        private void BtnFiveFingers_Click(object sender, EventArgs e)
        {
            AddFiveFinger();

        }

        private void BtnFiveGrandmas_Click(object sender, EventArgs e)
        {
            AddFiveGrandma();

        }

        private void BtnFiveRobots_Click(object sender, EventArgs e)
        {
            AddFiveRobot();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(89,	53,	31));
            fallDoc.Draw(e.Graphics);

        }

        private void pbCookie_MouseDown(object sender, MouseEventArgs e)
        {
            ClickCookieDown();
        }

        private void pbCookie_MouseUp(object sender, MouseEventArgs e)
        {
            ClickCookieUp();
        }

        private void timeLabelDisappear_Tick(object sender, EventArgs e)
        {
            lbPlusCookie_1.Visible = false;
        }

        private void lbPlusCookie_Click(object sender, EventArgs e)
        {
            ClickCookieDown();
        }
    }
}
