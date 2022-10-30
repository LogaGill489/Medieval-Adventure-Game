using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Threading;
using Medieval_Adventure_Game.Properties;
using System.Media;
using System.Reflection;
using System.Drawing.Printing;
using System.Resources;

/*
 * Adventure To Amsera Choose Your Own Adventure Game
 * Logan Gillett
 * Mr T.
 * 10.30.2022
 * ICS3U
 */

namespace Medieval_Adventure_Game
{
    public partial class Form1 : Form
    {
        //page tracking and random variables
        Random random = new Random();
        int page = 1;
        int chance;

        //Soundplayer variables
        //(I'd like to figure out how to make a sound player array at somepoint if possible because yes, I am fully aware this is not ideal)
        #region Soundplayer Variables Are Collapsed Here

        //human noises:
        SoundPlayer footstepsNoise = new SoundPlayer(Resources.footstepsSound);
        SoundPlayer gnomeNoise = new SoundPlayer(Resources.gnomeSound);
        SoundPlayer snoringNoise = new SoundPlayer(Resources.snoringSound);
        SoundPlayer traderNoise = new SoundPlayer(Resources.maletalkingSound);
        SoundPlayer yellNoise = new SoundPlayer(Resources.yellSound);

        //sword noises:
        SoundPlayer swordNoise = new SoundPlayer(Resources.swordshingSound);
        SoundPlayer sword2Noise = new SoundPlayer(Resources.swordswingSound);
        SoundPlayer sword3Noise = new SoundPlayer(Resources.swordsliceSound);
        SoundPlayer sword4Noise = new SoundPlayer(Resources.swordslice2Sound);
        SoundPlayer sword5Noise = new SoundPlayer(Resources.sworddrawingSound);

        //natural noises:
        SoundPlayer branchNoise = new SoundPlayer(Resources.branchshakingSound);
        SoundPlayer bushesNoise = new SoundPlayer(Resources.bushesSound);
        SoundPlayer dirtNoise = new SoundPlayer(Resources.dirtSound);
        SoundPlayer windNoise = new SoundPlayer(Resources.windSound);
        SoundPlayer wind2Noise = new SoundPlayer(Resources.wind2Sound);
        SoundPlayer wind3Noise = new SoundPlayer(Resources.wind3Sound);
        SoundPlayer wind4Noise = new SoundPlayer(Resources.wind4Sound);

        //animal noises:
        SoundPlayer birdNoise = new SoundPlayer(Resources.birdSound);
        SoundPlayer cricketNoise = new SoundPlayer(Resources.cricketSound);
        SoundPlayer gallopNoise = new SoundPlayer(Resources.gallopSound);
        SoundPlayer horseNoise = new SoundPlayer(Resources.horseSound);
        SoundPlayer ravenNoise = new SoundPlayer(Resources.raven1Sound);
        SoundPlayer raven2Noise = new SoundPlayer(Resources.raven2Sound);

        //prop noises:
        SoundPlayer appleNoise = new SoundPlayer(Resources.appleSound);
        SoundPlayer basketNoise = new SoundPlayer(Resources.basketSound);
        SoundPlayer breadNoise = new SoundPlayer(Resources.breadSound);
        SoundPlayer hornNoise = new SoundPlayer(Resources.foghornSound);
        SoundPlayer horn2Noise = new SoundPlayer(Resources.trumpetSound);

        //misc noises:
        SoundPlayer magicNoise = new SoundPlayer(Resources.magicspellSound);
        SoundPlayer pushingNoise = new SoundPlayer(Resources.shovingSound);
        SoundPlayer rockNoise = new SoundPlayer(Resources.rockhittingSound);
        SoundPlayer rollingcartNoise = new SoundPlayer(Resources.rollingcartSound);
        SoundPlayer woodNoise = new SoundPlayer(Resources.wooddestroyedSound);

        #endregion

        public Form1()
        {
            InitializeComponent();
            //sets inital image and text for the game to start on
            outputLabel.Text = $"You wake up on a cart that travels a dirt road, completely unaware of your surroundings.  There are three other passengers.  What do you do?";
            firstOutput.Text = $"Ask them where you are";
            secondOutput.Text = $"Jump from the cart";
            thirdOutput.Text = $"Do nothing";
            pageImage.BackgroundImage = Resources.travellingcartImage;
            //plays a 1 time startup noise
            horn2Noise.Play();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //long if statement that decides what page to go to upon a button click
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
                //calculates if bandits will appear (70% chance)
                chance = random.Next(1, 101);
                if (chance < 70)
                    {
                    page = 6;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 22;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 36;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 31)
            {
                //gives a 10% chance to have an end screen upon clicking button 31
                chance = random.Next(1, 101);
                if (chance < 10)
                {
                    page = 32;
                }
                else
                {
                    page = 33;
                }
            }
            else if (page == 32)
            {
                page = 1;
            }
            else if (page == 33)
            {
                //mirror page of 31
                chance = random.Next(1, 101);
                if (chance < 10)
                {
                    page = 32;
                }
                else
                {
                    page = 33;
                }
            }
            else if (page == 34)
            {
                page = 1;
            }
            else if (page == 35)
            {
                page = 1;
            }
            else if (page == 36)
            {
                page = 38;
            }
            else if (page == 37)
            {
                page = 1;
            }
            else if (page == 38)
            {
                page = 39;
            }
            else if (page == 39)
            {
                page = 40;
            }
            else if (page == 40)
            {
                page = 41;
            }
            else if (page == 41)
            {
                page = 1;
            }

            //goes to a seperate private void that holds a switch block
            pageDisplay();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //long if statement that decides what page to go to upon a button click
            if (page == 1)
            {
                page = 14;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                //creates a 3 way chance of an outcome upon clicking a button, including a 20% and 2 40% chances
                chance = random.Next(1, 101);
                if (chance < 20)
                {
                    page = 10;
                }
                else if (chance > 20 && chance < 60)
                {
                    page = 11;
                }
                else
                {
                    page = 12;
                }
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 18)
            {
                page = 23;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 28;
            }
            else if (page == 27)
            {
                page = 30;
            }
            else if (page == 28)
            {
                page = 37;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 34;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 34;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 35)
            {
                page = 99;
            }
            else if (page == 36)
            {
                page = 2;
            }
            else if (page == 37)
            {
                page = 99;
            }
            else if (page == 38)
            {
                page = 2;
            }
            else if (page == 39)
            {
                page = 2;
            }
            else if (page == 40)
            {
                page = 2;
            }
            else if (page == 41)
            {
                page = 99;
            }

            //goes to a seperate private void that holds a switch block
            pageDisplay();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //certain pages only in the if statement
            //only those that include a 3rd button option are needed in it
            if (page == 1)
            {
                page = 26;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 8;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 27)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 35;
            }
            else if (page == 33)
            {
                page = 35;
            }

            //goes to a seperate private void that holds a switch block
            pageDisplay();
        }

        //3 seperate clicks that cover the text boxes for easy clicking access
        //each lead to their respective if statement codes
        private void firstOutput_Click(object sender, EventArgs e)
        {
            option1Button_Click(sender, e);
        }

        private void secondOutput_Click(object sender, EventArgs e)
        {
            option2Button_Click(sender, e);
        }

        private void thirdOutput_Click(object sender, EventArgs e)
        {
            option3Button_Click(sender, e);
        }

        //seperate private void used to save unneccesary repetition after each button
        //also works as a much more organized example of the page system
        private void pageDisplay()
        {
            //switch statement that contains everything neccesary to make each page appear and have any form of special effect, visual or sound
            switch (page)
            {
                case 1:
                    //plays noise
                    sword3Noise.Play();

                    //displays 3rd button if the player restarts the game
                    option3Button.Visible = true;
                    thirdOutput.Visible = true;

                    //refreshes home screen for a new game
                    pageImage.Image = null;
                    pageImage.BackgroundImage = Resources.travellingcartImage;
                    outputLabel.Text = "You wake up on a cart that travels a dirt road, completely unaware of your surroundings.  There are three other passengers.  What do you do?";
                    firstOutput.Text = "Ask Them Where You Are";
                    secondOutput.Text = "Jump From the Cart";
                    thirdOutput.Text = "Do Nothing";
                    break;
                case 2:
                    //plays noise
                    gallopNoise.Play();

                    //displays 3rd button in the event that page 2 is accessed under the third path
                    option3Button.Visible = true;
                    thirdOutput.Visible = true;

                    //creates page 2
                    pageImage.BackgroundImage = Resources.fallforestImage;
                    pageImage.Image = Resources.ofnir1Image;
                    outputLabel.Text = "You ask one of the men where you are. He says his name is Ofnir, and you are on the road to Amsera. What do you do?";
                    firstOutput.Text = "Talk About the Journey";
                    secondOutput.Text = "Look for Food";
                    thirdOutput.Text = "Attack Ofnir While his Guard is Down";
                    break;
                case 3:
                    //plays noise
                    birdNoise.Play();

                    //creates page 3
                    pageImage.BackgroundImage = Resources.fallforest3Image;
                    pageImage.Image = Resources.ofnir6Image;
                    outputLabel.Text = "You talk about your future journey. Ofnir says it will take 3 days to reach Amsera if luck would have the road so you should get comfy. What do you do next?";
                    firstOutput.Text = "Continue Journey";
                    secondOutput.Text = "Grab and Inspect Ofnir's Sword";
                    thirdOutput.Text = "Attempt to Hijack the Cart";
                    break;
                case 4:
                    //play noise
                    appleNoise.Play();

                    //creates page 4s end screen
                    pageImage.BackgroundImage = Resources.applebasketImage;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You realize quite suddenly that you are hungry, so you look for food. You discover an apple in a bag, but it turns out to be poisonous! You die shortly after. Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 5:
                    //makes screen go black
                    outputLabel.Text = "";
                    pageImage.BackColor = Color.Black;
                    pageImage.Image = null;
                    pageImage.BackgroundImage = null;
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    //plays noises
                    pushingNoise.Play();
                    Refresh();
                    Thread.Sleep(1300);
                    pushingNoise.Stop();
                    Refresh();
                    Thread.Sleep(300);
                    swordNoise.Play();
                    Refresh();
                    Thread.Sleep(2000); 

                    //after the noises are done, brings up an end screen
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    pageImage.BackgroundImage = Resources.travellingcart2Image;
                    outputLabel.Text = "You attack Ofnir, pushing him off the cart in one fowl swoop. Suddenly, you get stabbed from behind! You die instantly, and the two other men throw you off the cart.";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 6:
                    //plays a noise
                    bushesNoise.Play();

                    //creates page 6
                    pageImage.BackgroundImage = Resources.fallroad2Image;
                    pageImage.Image = Resources.bandits1Image;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You continue your journey for a day, but suddenly, a group of bandits come out of the bushes, looking to ransack the cart! What do you do?";
                    firstOutput.Text = "Bargin With the Bandits";
                    secondOutput.Text = "Fight the Bandits";
                    break;
                case 7:
                    //changes image
                    pageImage.BackgroundImage = Resources.swordImage;
                    pageImage.Image = null;
                    outputLabel.Text = "";
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    //plays pushing noise
                    pushingNoise.Play();
                    Refresh();
                    Thread.Sleep(800);
                    swordNoise.Stop();
                    rockNoise.Play();
                    Refresh();
                    Thread.Sleep(500);

                    //displays new endscreen page
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    pageImage.BackgroundImage = Resources.caveImage;
                    outputLabel.Text = "Seeing his sword, you reach for it to get a better look.  Ofnir, thinking you are making a move, grabs it first and throws you off the cart. You die from the impact! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 8:
                    //plays noise
                    sword4Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.travellingcart3Image;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You quickly jump to the front of the cart and attempt to deatach the carage from where the rest of the crew is siting. They attack you, and you are overwhelmed from their force. You die! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 9:
                    //plays noise
                    woodNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.destroyedcartImage;
                    pageImage.Image = null;
                    outputLabel.Text = "You bargin with the bandits for you and your crews lives, but the bandits don't listen! They wipe out you and your crew and rob the cart! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 10:
                    //plays noise
                    sword2Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.amsera1Image;
                    pageImage.Image = null;
                    outputLabel.Text = "You fight the bandits, and fend them off. Your crew gets a reputation as fighters, and you make it to Amsera unharmed! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";

                    //delays 0.3 of a second before repeating the sound again to add a better effect
                    Refresh();
                    Thread.Sleep(300);
                    sword2Noise.Play();
                    break;
                case 11:
                    //plays noise
                    ravenNoise.Play();

                    //displays another end screen
                    pageImage.BackgroundImage = Resources.darkforest3Image;
                    pageImage.Image = null;
                    outputLabel.Text = "You attempt to fight off the bandits, but you and your crew are quickly overwhelmed. They kill you and your crew and rob the cart! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 12:
                    //plays noise
                    raven2Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.darkforest2Image;
                    pageImage.Image = null;
                    outputLabel.Text = "You fight off the bandits and manage to fend them off, but you are the only crew member left behind. You get attacked by bandits a day later, and cannot fend them off on your own. You die, losing the cart with you! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 13:
                    //plays noise
                    horn2Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.amsera2Image;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You make it to Amsera along the road without any trouble! From here, you can start a new life in this world! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 14:
                    //plays noise
                    dirtNoise.Play();

                    //creates page 14
                    pageImage.BackgroundImage = Resources.dirtroadImage;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "Realizing you could be in danger, you jump from the cart! You face a small bruise on your left leg but are otherwise unharmed. Where to next?";
                    firstOutput.Text = "Left";
                    secondOutput.Text = "Right";
                    break;
                case 15:
                    //plays noise
                    rollingcartNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.dirtroad2Image;
                    outputLabel.Text = "You travel left on the road, but don't find anything for many kilometers! You die of starvation on the road! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 16:
                    //plays noise
                    traderNoise.Play();

                    //creates page 16
                    pageImage.BackgroundImage = Resources.fallforestImage;
                    pageImage.Image = Resources.friendlytraderImage;
                    outputLabel.Text = "You head right down the road, following the cart you jumped out of. Down the road, you meet a trader, looking for business with travelers. Do you bargin with him?";
                    firstOutput.Text = "Yes";
                    secondOutput.Text = "No";
                    break;
                case 17:
                    //hides screen
                    outputLabel.Text = "";
                    pageImage.Image = null;
                    pageImage.BackgroundImage = null;
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;

                    //delays and plays noise
                    bushesNoise.Play();
                    Refresh();
                    Thread.Sleep(2000);

                    //brings back new display
                    pageImage.BackgroundImage = Resources.fallforestImage;
                    pageImage.Image = Resources.medievaltraderImage;
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    option3Button.Visible = true;
                    thirdOutput.Visible = true;
                    outputLabel.Text = "You attempt to bargin with the trader, but out the bushes comes an assassin that pulls out a knife and demands that you give him everything you own! What do you do?";
                    firstOutput.Text = "Do as he says";
                    secondOutput.Text = "Attempt to steal the trader's horse";
                    thirdOutput.Text = "Run away";
                    break;
                case 18:
                    //plays noise
                    footstepsNoise.Play();

                    //creates page 18
                    pageImage.BackgroundImage = Resources.forestroadImage;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You walk past the trader, realizing that you don't have money anyway! Where do you go next?";
                    firstOutput.Text = "Follow the path";
                    secondOutput.Text = "Explore the woods";

                    //delays 0.4 of a second before repeating the sound again to add a better effect
                    Refresh();
                    Thread.Sleep(400);
                    footstepsNoise.Play();
                    break;
                case 19:
                    //plays noise
                    gallopNoise.Play();

                    //removes button 3 from being accessable
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.darkroadImage;
                    pageImage.Image = null;
                    outputLabel.Text = "You don't resist, giving him everything you have. He rides away on his horse, and leaves you on the road helpless. You die of starvation! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 20:
                    //plays noise
                    horseNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.horsewoodsImage;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "Realizing the trader is in on the scam, you make an attempt to steal his horse, and manage to climb on. You get away, and ride off into the sunset with your new companion! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 21:
                    //new end screen display
                    sword4Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.skywardforestImage;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You run away as fast as you can, but the bandit quickly catchs you on his horse. He stabs you in the back, jousting you with his sword, and killing you instantly! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 22:
                    //plays noise
                    rollingcartNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.roadbendImage;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You follow the path, but find nothing for many kilometers. Realizing you forgot to grab food, you die of starvation! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 23:
                    //hides screen
                    outputLabel.Text = "";
                    pageImage.BackgroundImage = null;
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;

                    //delays and plays noise
                    branchNoise.Play();
                    Refresh();
                    Thread.Sleep(3000);

                    //brings back new display
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    pageImage.BackgroundImage = Resources.gnomevillageImage;
                    outputLabel.Text = "You decide to explore the woods, and find a small village. After watching them for a time, you determine it to be a village of gnomes! What do you do?";
                    firstOutput.Text = "Try to Socialize With the Gnomes";
                    secondOutput.Text = "Attack!";
                    break;
                case 24:
                    //plays noise
                    gnomeNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.gnomevillage2Image;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You attempt to socialize with the gnomes. After a long talk together, they determine you aren't a threat and declare you the town protector! You stay with them for the rest of your days. Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 25:
                    //plays noise
                    sword5Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.mushroomImage;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You attack the gnomes, stomping on them and kicking them as you went! You defeat the entire village, but die of your wounds shortly after! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 26:
                    //plays noise
                    wind3Noise.Play();

                    //creates page 26
                    pageImage.BackgroundImage = Resources.dirtroadImage;
                    pageImage.Image = Resources.ofnir1Image;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You get up and do nothing. After all, it's better to say less than too much, right? Everyone looks at eachother awkwardly. Do you say something?";
                    firstOutput.Text = "Yes";
                    secondOutput.Text = "No";
                    break;
                case 27:
                    //plays noise
                    basketNoise.Play();

                    //makes button 3 accessable for page 27
                    option3Button.Visible = true;
                    thirdOutput.Visible = true;

                    //creates page 27
                    pageImage.BackgroundImage = Resources.basketImage;
                    pageImage.Image = null;
                    outputLabel.Text = "You try to say something but stop yourself before a noise leaves your mouth. The man was reaching into his bag for something! What do you do?";
                    firstOutput.Text = "Yell";
                    secondOutput.Text = "Attack Him!";
                    thirdOutput.Text = "Do Nothing";
                    break;
                case 28:
                    //plays noise
                    windNoise.Play();

                    //creates page 28
                    pageImage.BackgroundImage = Resources.fallforest2Image;
                    pageImage.Image = Resources.ofnir2Image;
                    outputLabel.Text = "You decide it is best to stay silent, for speaking could be a grave mistake! Everyone still stares at each other awkwardly. Do you say something?";
                    firstOutput.Text = "Yes";
                    secondOutput.Text = "No";
                    break;
                case 29:
                    //plays noise
                    yellNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.fallforest3Image;
                    pageImage.Image = Resources.ofnir4Image;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You yell at the man as loud as you can, making the birds jump from the trees, but he just looks up and stares at you. You die of akwardness! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 30:
                    //makes screen go black
                    outputLabel.Text = "";
                    pageImage.BackColor = Color.Black;
                    pageImage.Image = null;
                    pageImage.BackgroundImage = null;
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    //plays noises
                    pushingNoise.Play();
                    Refresh();
                    Thread.Sleep(1300);
                    pushingNoise.Stop();
                    Refresh();
                    Thread.Sleep(300);
                    sword4Noise.Play();
                    Refresh();
                    Thread.Sleep(2000);

                    //after the noises are done, brings up an end screen
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    pageImage.BackgroundImage = Resources.travellingcart2Image;
                    pageImage.Image = null;
                    outputLabel.Text = "Thinking he was pulling a weapon from the bag, you attack him. You push him off the cart, but get stabbed from behind by the other companions. You die instantly! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 31:
                    //plays noise
                    breadNoise.Play();

                    //creates page 31
                    pageImage.BackgroundImage = Resources.fallforestImage;
                    pageImage.Image = Resources.ofnir5Image;
                    outputLabel.Text = "You do nothing, and watch the man intently as he pulls out a slice of bread from his bag and begins eating it. What do you do?";
                    firstOutput.Text = "Ask For a Bite";
                    secondOutput.Text = "Look Into His Bag";
                    thirdOutput.Text = "Do Nothing";
                    break;
                case 32:
                    //plays bread noise
                    breadNoise.Play();

                    //shows an angry image of ofnir with a delay
                    pageImage.Image = Resources.ofnir3Image;
                    outputLabel.Text = "";
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    Refresh();
                    Thread.Sleep(1500);

                    //displays end screen
                    pageImage.BackgroundImage = Resources.darkforest3Image;
                    pageImage.Image = null;
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true;
                    outputLabel.Text = "You ask for a bite, and the man hands the bread over. Instantly, however, he becomes outraged! You realize you've eaten the enitre slice in one bite! The man instantly kills for your sins! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 33:
                    //plays bread noise
                    breadNoise.Play();

                    //removes everything but image + delays
                    outputLabel.Text = "";
                    option1Button.Visible = false;
                    firstOutput.Visible = false;
                    option2Button.Visible = false;
                    secondOutput.Visible = false;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;

                    Refresh();
                    Thread.Sleep(300);

                    //brings everything back
                    option1Button.Visible = true;
                    firstOutput.Visible = true;
                    option2Button.Visible = true;
                    secondOutput.Visible = true; 
                    option3Button.Visible = true;
                    thirdOutput.Visible = true;
                    outputLabel.Text = "You ask for a bite, and the man hands it over. You take a bite and hand it back, feeling slighty more refreshed than before. What do you do?";
                    firstOutput.Text = "Ask For a Bite";
                    secondOutput.Text = "Look Into His Bag";
                    thirdOutput.Text = "Do Nothing";
                    break;
                case 34:
                    //plays noise
                    appleNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.appleImage;
                    pageImage.Image = null;
                    outputLabel.Text = "You reach into his bag, and find an apple. You eat the apple, but start choking! The apple was poisonous, and you die from poison! Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 35:
                    //plays noise
                    snoringNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.bread1Image;
                    pageImage.Image = null;
                    option3Button.Visible = false;
                    thirdOutput.Visible = false;
                    outputLabel.Text = "You do nothing, watching the man eat his bread piece for hours. You watch without sound or thought, and eventually pass into a long, blissful sleep about bread. You never wake up. Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 36:
                    //plays noise
                    wind2Noise.Play();

                    //creates page 36
                    pageImage.BackgroundImage = Resources.mountains1Image;
                    pageImage.Image = null;
                    outputLabel.Text = "You finally decide to speak. The man starts talking about the world, from the Three Peaks in the south to the High Plain of Gofnir. You eventually start talking about the rise of mages in the Dirnyl region. What next?";
                    firstOutput.Text = "Continue Conversation";
                    secondOutput.Text = "Ask Where You Are";
                    break;
                case 37:
                    //plays noise
                    cricketNoise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.fantasywoodsImage;
                    pageImage.Image = Resources.ofnir4Image;
                    outputLabel.Text = "You begin a long staring contest that lasts a lifetime. The event is known in history later as the Great Beholding War, and you and the man pass into legend for your staring skills. Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 38:
                    //plays noise
                    woodNoise.Play();

                    //creates page 38
                    pageImage.BackgroundImage = Resources.burningtreeImage;
                    outputLabel.Text = "You continue the conversation with the man, talking about the fall of the Dark River to the west. The man also tells of the fall of the Orphic Tree in Arbor, slightly east of that, claiming it is dark times ahead. What next?";
                    firstOutput.Text = "Continue Conversation";
                    secondOutput.Text = "Ask Where You Are";
                    break;
                case 39:
                    //plays noise
                    magicNoise.Play();

                    //creates page 39
                    pageImage.BackgroundImage = Resources.mountains2Image;
                    outputLabel.Text = "You continue the conversation and learn about the Gray Mountains to the high northeast. The man claims it to be his homeland, but says it was recently taken over by a sorceror named Gafdyn, who now rules the mountain range. What next?";
                    firstOutput.Text = "Continue Conversation";
                    secondOutput.Text = "Ask Where You Are";
                    break;
                case 40:
                    //plays noise
                    hornNoise.Play();

                    //creates page 40
                    pageImage.BackgroundImage = Resources.evilImageImage;
                    outputLabel.Text = "You keep talking to the man who talks of the evil from the south in the Fordurq Wastes. You listen intently as he describes their plans to march across the Narovalin Desert. What next?";
                    firstOutput.Text = "Continue Conversation";
                    secondOutput.Text = "Ask Where You Are";
                    break;
                case 41:
                    //plays noise
                    wind4Noise.Play();

                    //creates an end screen
                    pageImage.BackgroundImage = Resources.spaceImage;
                    outputLabel.Text = "You talk for an ungodly amount of time about the world around you, feeling quite happy about this arrangement. You become an expert in the political state of this world, continuing your conversation until the end of your days. Play again?";
                    firstOutput.Text = "Play Again";
                    secondOutput.Text = "End Your Adventure";
                    break;
                case 99:
                    //displays a thank you message
                    outputLabel.TextAlign = ContentAlignment.MiddleCenter;
                    outputLabel.Text = "Thank you for playing! I hope you enjoyed your adventure!";

                    //disables any trace of buttons
                    firstOutput.Visible = false;
                    secondOutput.Visible = false;
                    thirdOutput.Visible = false;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;

                    //delays and closes
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
