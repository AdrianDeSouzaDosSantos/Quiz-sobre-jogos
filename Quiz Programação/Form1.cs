using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Programação
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int corretAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;



        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 6;
        }

        private void checkAwnserEvent(object sender, EventArgs e)
        {
            
            
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == corretAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);


                MessageBox.Show(
                    "O Quiz chegou ao fim :v" + Environment.NewLine +
                    "Você respondeu " + score +" Questões corretamente." + Environment.NewLine +
                    "Sua porcentagem Total é de " + percentage + "%" + Environment.NewLine +
                    "Clique em Ok para jogar de novo :3"

               );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);


            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.DS3;

                    lblQuestion.Text = "Qual empresa publicou Dark souls 3?";

                        button1.Text = "From Software";
                    button2.Text = "Epic Games";
                    button3.Text = "ubisoft";
                    button4.Text = "EAGames";

                    corretAnswer = 1;

                        break;

                case 2:
                    pictureBox1.Image = Properties.Resources.goldeneye_64;

                    lblQuestion.Text = "Qual jogo aparece nesta foto?";

                    button1.Text = "halo";
                    button2.Text = "The Witcher";
                    button3.Text = "The last of us";
                    button4.Text = "Golden eye";

                    corretAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Infamous;

                    lblQuestion.Text = "Quantos jogos tem na franquia Infamous?";

                    button1.Text = "1";
                    button2.Text = "4";
                    button3.Text = "3";
                    button4.Text = "2";

                    corretAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Supermario;

                    lblQuestion.Text = "Em SuperMarioBrothers, qual o nome do irmão de Mário?";

                    button1.Text = "Luigi Mário";
                    button2.Text = "Roger";
                    button3.Text = "Luigui Koppa";
                    button4.Text = "Helicoptero de combate";

                    corretAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Gow_2;

                    lblQuestion.Text = "Qual o ano de lançamento de God Of War 2?";

                    button1.Text = "2001";
                    button2.Text = "2010";
                    button3.Text = "2077";
                    button4.Text = "2007";

                    corretAnswer = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Tennis;

                    lblQuestion.Text = "Qual o primeiro jogo inventado?";

                    button1.Text = "Pong";
                    button2.Text = "Tetris";
                    button3.Text = "Tennis for Two";
                    button4.Text = "Polybios";

                    corretAnswer = 3;

                    break;



            }



        }


    }
}
