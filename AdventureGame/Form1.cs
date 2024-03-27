using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        Random randGen = new Random();

        SoundPlayer gun = new SoundPlayer(Properties.Resources.gunSound);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.loseSound);
        SoundPlayer theme = new SoundPlayer(Properties.Resources.themeSound);
        SoundPlayer win = new SoundPlayer(Properties.Resources.winSound);
        SoundPlayer zombie = new SoundPlayer(Properties.Resources.zombieSound); 
        SoundPlayer running = new SoundPlayer(Properties.Resources.runningSound);
        SoundPlayer driving = new SoundPlayer(Properties.Resources.drivingSound);
        SoundPlayer talking = new SoundPlayer(Properties.Resources.talkingSound);
        SoundPlayer walking = new SoundPlayer(Properties.Resources.walkingSound);
        SoundPlayer banging = new SoundPlayer(Properties.Resources.bangingSound);
        public Form1()
        {
            InitializeComponent();
            theme.Play();

        }
        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 10;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 20;
            }
            else if (page == 15)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 29;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 26;
            }
            else if (page == 23)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue <= 70)
                {
                    page = 27;
                }
                else
                {
                    page = 39;
                }
            }
            else if (page == 27)
            {
                page = 26;
            }
            else if (page == 28)
            {
                page = 26;
            }
            else if (page == 29)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 33;
            }
            else if (page == 34)
            {
                page = 35;
            }
            else if (page == 37)
            {
                page = 99;
            }

            displayPage();

        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 1;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 14;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 14)
            {
                page = 19;
            }
            else if (page == 15)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 25;
            }
            else if (page == 20)
            {
                page = 24;
            }
            else if (page == 21)
            {
                page = 20;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 30;
            }
            else if (page == 29)
            {
                page = 32;
            }
            else if (page == 31)
            {
                page = 34;
            }
            else if (page == 34)
            {
                page = 37;
            }
            else if (page == 37)
            {
                page = 38;
            }
            else if (page == 99)
            {
                page = 1;
            }

            displayPage();

        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            if (page == 8)
            {
                page = 11;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 27)
            {
                page = 28;
            }

            displayPage();

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 22)
            {
                page = 20;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 36)
            {
                page = 37;
            }
            else if (page == 99)
            {
                page = 1;
            }
            else if (page == 100)
            {
                page = 1;
            }
            else
            {
                page = 100;
            }

            displayPage();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayPage()
        {
            switch (page)
            {
                case 1:
                    proceedButton.Location = new Point(253, 277);

                    proceedButton.Text = "Start";

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    closeButton.Visible = false;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;
                    closeButton.Enabled = false;

                    outputLabel.Text = "Welcome to the Apocalypse Survival Game.\nYour goal is simple ... SURVIVE.\nThe rules are simple each round you will choose exactly what it is you want to do.\nGood Luck.";
                    imageLabel.Image = Properties.Resources.page1Image;

                    theme.Play();
                    break;
                case 2:
                    optionButton1.Visible = true;
                    optionButton2.Visible = true;
                    proceedButton.Visible = false;
                    optionButton1.Enabled = true;
                    optionButton2.Enabled = true;
                    proceedButton.Enabled = false;

                    proceedButton.Text = "Continue";

                    optionButton1.Text = "Open the door";
                    optionButton2.Text = "Lock the door";

                    outputLabel.Text = "The apocalypse has been going on for 3 weeks now. You are minding your own business rationing at home when suddenly you hear banging on your door. You peer out the window and to your surprise you see a man. What do you do?";
                    imageLabel.Image = Properties.Resources.page2Image;

                    banging.Play();
                    break;
                case 3:
                    optionButton1.Text = "Run Away";
                    optionButton2.Text = "Fight the zombie";

                    outputLabel.Text = "You open the door and the man rushes in. To your surprise a zombie follows soon behind. What do you do?";
                    imageLabel.Image = Properties.Resources.page3Image;

                    zombie.Play();
                    break;
                case 4:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "The man smashes your window and shoots you. \n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page4Image;

                    lose.Play();
                    break;
                case 5:
                    optionButton1.Text = "Jump the fence";
                    optionButton2.Text = "Go back inside and fight";

                    outputLabel.Text = "You start running as fast as you can towards the back door the man quickly follows. You both run into the yard and reach the fence. What do you do?";
                    imageLabel.Image = Properties.Resources.page5Image;

                    running.Play();
                    break;
                case 6:
                    optionButton1.Text = "Help him";
                    optionButton2.Text = "Run away";

                    outputLabel.Text = "While you are fighting the zombie the zombie pins the man against the wall and is about to bite him. What do you do?";
                    imageLabel.Image = Properties.Resources.page6Image;

                    zombie.Play();
                    break;
                case 7:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You jumped into a herd of zombies and get bit\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page7Image;

                    lose.Play();
                    break;
                case 8:
                    optionButton3.Enabled = true;
                    optionButton3.Visible = true;

                    optionButton1.Text = "Go with man";
                    optionButton2.Text = "Decline his offer";
                    optionButton3.Text = "Find out more about his city";

                    outputLabel.Text = "You shot the zombie in the head killing it and the man seems to be very grateful for you saving him. To thank you he promises you a house in his walled city. What do you do?";
                    imageLabel.Image = Properties.Resources.page8Image;

                    gun.Play();
                    break;
                case 9:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "The man emerges from the house as a zombie and kills you\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page9Image;

                    lose.Play();
                    break;
                case 10:
                    optionButton3.Enabled = false;
                    optionButton3.Visible = false;

                    optionButton1.Text = "Pull over and help the family";
                    optionButton2.Text = "Keep driving";

                    outputLabel.Text = "You are driving through the city on your way to the compound when you see a family on the side of the road trapped by zombies. What do you do?";
                    imageLabel.Image = Properties.Resources.page10Image;

                    driving.Play();
                    break;
                case 11:
                    optionButton3.Enabled = false;
                    optionButton3.Visible = false;

                    optionButton1.Text = "Go with man to his city";
                    optionButton2.Text = "Decline his offer";

                    outputLabel.Text = "The man begins to tell you exactly what you want to hear in attempt to convince you to go with him. ";
                    imageLabel.Image = Properties.Resources.page11Image;

                    talking.Play();
                    break;
                case 12:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You stay at home but eventually run out of food and starve to Death.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page12Image;

                    lose.Play();
                    break;
                case 13:
                    optionButton3.Enabled = true;
                    optionButton3.Visible = true;

                    optionButton1.Text = "Go with family";
                    optionButton2.Text = "Leave the man and family";
                    optionButton3.Text = "Stay with the man";

                    outputLabel.Text = "You save the family and they are very grateful for the service. They invite you and the man to travel with them but the man refuses. What do you do?";
                    imageLabel.Image = Properties.Resources.page13Image;

                    talking.Play();
                    break;
                case 14:
                    optionButton1.Text = "Follow the man inside";
                    optionButton2.Text = "Kill the man before he enters the warehouse";
                    optionButton3.Text = "Run away";

                    outputLabel.Text = "The man pulls the car over at an abandoned warehouse and gets out. He then proceeds to enter. What do you do?";
                    imageLabel.Image = Properties.Resources.page14Image;

                    driving.Play();
                    break;
                case 15:
                    optionButton3.Enabled = false;
                    optionButton3.Visible= false;

                    optionButton1.Text = "Walk away";
                    optionButton2.Text = "Enter";

                    outputLabel.Text = "You and the family walk so far that you enter the city and stumble across the mans car parked outside an abandoned warehouse. What do you do?";
                    imageLabel.Image = Properties.Resources.page15Image;

                    walking.Play();
                    break;
                case 16:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton3.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    optionButton3.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "The man is driving away and hits you with his car.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page16Image;

                    lose.Play();
                    break;
                case 17:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton3.Visible = false;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    optionButton3.Enabled = false;

                    outputLabel.Text = "You follow the man inside but he is waiting around the corner and knocks you unconscious. When you wake up you find you have been tied up.";
                    imageLabel.Image = Properties.Resources.page17Image;
                    break;
                case 18:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton3.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    optionButton3.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You attempt to run away but the man shoots you dead.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page18Image;

                    lose.Play();
                    break;
                case 19:
                    optionButton3.Enabled = false;
                    optionButton3.Visible = false;

                    optionButton1.Text = "Untie everyone";
                    optionButton2.Text = "Pretend you saw nothing and run";

                    outputLabel.Text = "You kill the man and enter the warehouse. To your surprise you find tons of people tied up. What do you do?";
                    imageLabel.Image = Properties.Resources.page19Image;

                    gun.Play();
                    break;
                case 20:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton3.Visible = false;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    optionButton3.Enabled = false;

                    outputLabel.Text = "You walk inside the building but the man is waiting behind the door.He knocks you unconscious.";
                    imageLabel.Image = Properties.Resources.page22Image;

                    Refresh();
                    Thread.Sleep(5000);
                      
                    optionButton1.Visible = true;
                    optionButton2.Visible = true;
                    optionButton1.Enabled = true;
                    optionButton2.Enabled = true;

                    optionButton1.Text = "Plan an escape";
                    optionButton2.Text = "Give up on escaping";

                    outputLabel.Text = "You are left tied up for what feels like 3 days. You get to know all the people around you. What do you do?";
                    imageLabel.Image = Properties.Resources.page20Image;

                    talking.Play();
                    break;
                case 21:
                    optionButton1.Text = "Keep going";
                    optionButton2.Text = "Go back";

                    outputLabel.Text = "You begin to walk away but feel as though you did something wrong. What do you do?";
                    imageLabel.Image = Properties.Resources.page21Image;

                    walking.Play();
                    break;
                case 23:
                    optionButton1.Text = "Go ahead with the plan";
                    optionButton2.Text = "Bail on the plan";

                    outputLabel.Text = "You are planning an escape but not everyone is willing to work with you. What do you do?";
                    imageLabel.Image = Properties.Resources.page23Image;

                    talking.Play();
                    break;
                case 24:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You starve to death\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page24Image;

                    lose.Play();
                    break;
                case 25:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You try and steal the car but the alarm goes off. A herd of zombies heard it and kill you\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page25Image;

                    lose.Play();
                    break;
                case 26:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You run into a herd of zombies and die\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page26Image;

                    lose.Play();
                    break;
                case 27:
                    optionButton3.Visible = true;
                    optionButton3.Enabled = true;

                    optionButton1.Text = "Run away";
                    optionButton2.Text = "Free everyone";
                    optionButton3.Text = "Only free peoplein on the plan";

                    outputLabel.Text = "The plan worked. You broke free and killed the man but no one else broke free. What do you do?";
                    imageLabel.Image = Properties.Resources.page27Image;

                    gun.Play();
                    break;
                case 28:
                    optionButton3.Enabled = false;
                    optionButton3.Visible = false;

                    optionButton1.Text = "Run away";
                    optionButton2.Text = "Attempt to stay with group";

                    outputLabel.Text = "The people you freed don't agree with your decision and free everyone else. Everyone decides to exhile you from the group. What do you do?";
                    imageLabel.Image = Properties.Resources.page28Image;

                    talking.Play();
                    break;
                case 29:
                    optionButton1.Text = "Go with them";
                    optionButton2.Text = "Don't go";

                    outputLabel.Text = "The people you are with have decided to go to a safe haven but are unsure if it is still standing. They ask if you want to come. What do you do?";
                    imageLabel.Image = Properties.Resources.page29Image;

                    talking.Play();
                    break;
                case 30:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "The people kill you.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page30Image;

                    lose.Play();
                    break;
                case 31:
                    optionButton1.Text = "Look for fuel";
                    optionButton2.Text = "Walk the rest of the way";

                    outputLabel.Text = "You all begin to drive to the safe haven but run out of fuel. What do you do?";
                    imageLabel.Image = Properties.Resources.page31Image;

                    driving.Play();
                    break;
                case 32:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You run into a herd of zombies and die.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page32Image;

                    lose.Play();
                    break;
                case 33:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "You find a gas station and enter it but a zombie is inside and kills you.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page33Image;

                    lose.Play();
                    break;
                case 34:
                    optionButton1.Text = "Set up camp";
                    optionButton2.Text = "Keep on walking";

                    outputLabel.Text = "It becomes night. What do you do?";
                    imageLabel.Image = Properties.Resources.page34Image;

                    walking.Play();
                    break;
                case 35:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "A zombie kills you while you are working.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page35Image;

                    lose.Play();
                    break;
                case 36:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;

                    outputLabel.Text = "You enter a clearing and see many lights in the distance. What do you do?";
                    imageLabel.Image = Properties.Resources.page36Image;
                    break;
                case 37:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;

                    outputLabel.Text = "You enter a clearing and see many lights in the distance. What do you do?";
                    imageLabel.Image = Properties.Resources.page36Image;

                    Refresh();
                    Thread.Sleep(5000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;
                    optionButton1.Enabled = true;
                    optionButton2.Enabled = true;

                    optionButton1.Text = "Enter the city";
                    optionButton2.Text = "Judge the legitamacy of the city";

                    outputLabel.Text = "You reach the walls of the city. What do you do?";
                    imageLabel.Image = Properties.Resources.page37Image;

                    banging.Play();
                    break;
                case 38:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "A guard mistakes you for a walker and get shot\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page38Image;

                    lose.Play();
                    break;
                case 39:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;

                    outputLabel.Text = "Your'e escape didn't work and you starve to death.\n\nYou Die!";
                    imageLabel.Image = Properties.Resources.page39Image;

                    lose.Play();
                    break;
                case 99:
                    proceedButton.Location = new Point(80, 277);
                    closeButton.Location = new Point(426, 277);

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    closeButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;
                    closeButton.Enabled = true;

                    proceedButton.Text = "To Lobby";

                    outputLabel.Text = "You Have Survived!!!\n\nPress to return to the lobby?";
                    imageLabel.Image = Properties.Resources.page1Image;

                    win.Play();
                    break;
                case 100:
                    proceedButton.Location = new Point(80, 277);
                    closeButton.Location = new Point(426, 277);

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;
                    proceedButton.Visible = true;
                    closeButton.Visible = true;
                    optionButton1.Enabled = false;
                    optionButton2.Enabled = false;
                    proceedButton.Enabled = true;
                    closeButton.Enabled = true;

                    proceedButton.Text = "To Lobby";

                    outputLabel.Text = "You Have Lost!\n\nPress to return to the lobby?";
                    imageLabel.Image = Properties.Resources.page1Image;

                    lose.Play();
                    break;
                default:
                    break;
            }
        }
    }
}