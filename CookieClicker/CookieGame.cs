using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;

namespace CookieClicker
{
    class CookieGame
    {
        public Cookie Cookie { get; set; }
        public float ClicksPerSecond { get; set; }
        public long CookiesCount { get; set; }
        public List<PowerUp> powerUps { get; set; }

        public static long FingersCount { get; set; }
        public static long GrandmasCount { get; set; }
        public static long RobotsCount { get; set; }
        public long TotalClicksCount { get; set; }
        public long TotalCookiesCount { get; set; }

        public CookieGame(Cookie cookie)
        {
            this.Cookie = cookie;
            powerUps = new List<PowerUp>();
            StartGame();
        }

        public void ClickCookie()
        {
            ++CookiesCount;
        }

   
        public void IncreaseClicksPerSecond(float increaseAmount)
        {
            Debug.WriteLine("Увеличение CPS... + {0}", increaseAmount);
            ClicksPerSecond += increaseAmount;
        }

      
        public void UpdateCookies()
        {
            CookiesCount += (int)ClicksPerSecond;
        }

       
        public void StartGame()
        {
            ClicksPerSecond = Constants.CLICKS_PER_SECOND;
            CookiesCount = 0;
            FingersCount = 0;
            GrandmasCount = 0;
            RobotsCount = 0;
        }


        public void UpdateCounts(PowerUp powerUp)
        {
            CookiesCount -= (long)powerUp.getCost();
            powerUp.IncreaseCount();
            if (powerUp is Finger)
            {
                PowerUpRates.UpdateFingerCosts();
            }

            else if (powerUp is Grandma)
            {
                PowerUpRates.UpdateGrandmaCosts();
            }

            else if (powerUp is Robot)
            {
                PowerUpRates.UpdateRobotCosts();
            }

            else if (powerUp is FiveFingers)
            {
                PowerUpRates.UpdateFiveFingersCosts();

            }

            else if (powerUp is FiveGrandmas)
            {
                PowerUpRates.UpdateFiveGrandmasCosts();

            }

            else if (powerUp is FiveRobots)
            {
                PowerUpRates.UpdateFiveRobotsCosts();

            }


        }


     
        public void AddPowerUp(PowerUp powerUp)
        {
            Debug.Write("Добавить улучшение... " + powerUp.ToString() + " с CPS: " + powerUp.ClicksPerSecond + " И цена: " + powerUp.Cost + " \n");
            this.powerUps.Add(powerUp);
            UpdateCounts(powerUp);
            IncreaseClicksPerSecond(powerUp.ClicksPerSecond);
        }
    }
}
