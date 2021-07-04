using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char[] charactersCapital;
        private char[] hiddenCharactersCapital;
        private string capital;
        private string country;
        private int lifePoints;
        private string[] capitalsList;

        private void loadFile()
        {
            string path = @"countries_and_capitals.txt";
            string readText = File.ReadAllText(path);

            capitalsList = readText.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );
        }

        private void show_mainBox_Click(object sender, EventArgs e)
        {
            loadFile();
            Random rand = new Random();
            int index = rand.Next(capitalsList.Length);
            string[] item = capitalsList[index].Split('|');
            capital = item[1].Substring(1);
            country = item[0];
            charactersCapital = capital.ToCharArray();
            hiddenCharactersCapital = new char[charactersCapital.Length];
            for (int i = 0; i < hiddenCharactersCapital.Length; i++)
            {
                if (charactersCapital[i].Equals(' ')) hiddenCharactersCapital[i] = ' ';
                else hiddenCharactersCapital[i] = '_';
            }
            string emptyCapital = new string(hiddenCharactersCapital);

            mainBox.Visible = true;
            mainBox.Text = emptyCapital;
            lifePoints = 5;
            lifePointsLbl.Visible = true;
            lifePointsLbl.Text = String.Format("Life points: {0}", lifePoints);
            notInWordLbl.Visible = true;
            notInWordList.Visible = true;
            notInWordList.Items.Clear();
            hintLbl.Visible = false;
            characterLbl.Visible = true;
            capitalLbl.Visible = true;
            userCharacterInput.Visible = true;
            userWordInput.Visible = true;
            checkCharacterBtn.Visible = true;
            checkWordBtn.Visible = true;
            show_mainBox.Visible = false;
            userNameInput.Visible = false;
            saveBtn.Visible = false;
        }

        private void checkCharacterBtn_Click(object sender, EventArgs e)
        {
            if(userCharacterInput.Text != "" && userCharacterInput.Text != " ") {
                char character = userCharacterInput.Text.ToCharArray()[0];
                bool miss = true;
                for (int i = 0; i < charactersCapital.Length; i++)
                {
                    if (charactersCapital[i].Equals(character))
                    {
                        hiddenCharactersCapital[i] = charactersCapital[i];
                        string revelcharactersCapital = new string(hiddenCharactersCapital);

                        mainBox.Text = revelcharactersCapital;
                        miss = false;
                    }
                }
                if(miss == true)
                {
                    lifePointsLbl.Text = String.Format("Life points: {0}", --lifePoints);
                    notInWordList.Items.Add(userCharacterInput.Text);
                    if(lifePoints < 1)
                    {
                        endGame(false);
                    }
                    if(lifePoints == 1)
                    {
                        hintLbl.Visible = true;
                        hintLbl.Text = String.Format("The capital of {0}", country);
                    }
                }
                else
                {
                    bool victory = true;
                    for (int i = 0; i < hiddenCharactersCapital.Length; i++) if (hiddenCharactersCapital[i].Equals('_')) victory = false;
                    if(victory == true)
                    {
                        endGame(true);
                    }
                }
            }
        }

        private void checkWordBtn_Click(object sender, EventArgs e)
        {
            if(userWordInput.Text != "")
            {
                string word = userWordInput.Text;
                if(word.Equals(capital))
                {
                    endGame(true);
                }
                else
                {
                    lifePoints -= 2;
                    lifePointsLbl.Text = String.Format("Life points: {0}", lifePoints);
                    if (lifePoints < 1)
                    {
                        endGame(false);
                    }
                }
            }
        }

        private void endGame(bool gameResult)
        {
            
            show_mainBox.Visible = true;
            show_mainBox.Text = "Restart";
            if (gameResult == true)
            {
                userNameInput.Visible = true;
                saveBtn.Visible = true;
                mainBox.Text = "You win!";
            }
            else mainBox.Text = "You lose!";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = userNameInput.Text;
            DateTime date = DateTime.Now;
            string record = String.Format("{0} | {1} | {2}\n", name, date, capital);
            File.WriteAllText("HighScore.txt", record);
        }
    }
}
