using UnityEngine;
using UnityEngine.UI;


    public class GameManager : MonoBehaviour
    {

        public Text PlayerNumberText;//玩家數字
        public Text ComNumberText;//電腦數字
        public Text ResultText;//勝負


     


        public void Game()
        {
            int PlayerNumber = Random.Range(1, 101); //玩家隨機抽取的數字範圍
            int ComNumber = Random.Range(1, 101);//電腦隨機抽取的數字範圍

            //縣示玩家和電腦的數字
            PlayerNumberText.text = "玩家分數" + PlayerNumber;
            ComNumberText.text = "電腦分數" + ComNumber;

            //判斷勝負
            if (PlayerNumber > ComNumber)
            {
                ResultText.text = ("你贏了");
            }
            else if (PlayerNumber < ComNumber)
            {

                ResultText.text = ("我輸了");

            }
            else
            {

                ResultText.text = ("平手");
            }
        }
    }



