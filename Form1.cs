using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Snake
{   
    public partial class SnakeRPG : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private FoodConsumable food = new FoodConsumable();
      
        int moves_made = 0;

        //Wraith Form
        Boolean wraith_form = false;
        int wraith_form_points = 5;

        int focus = 0;

        //Global mute
        Boolean muted = false;
        Boolean lvlupsound = false;

        //Focus ability function
        public void focus_effect()
        {    
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        public SnakeRPG()
        {

            InitializeComponent();

            //Set settings to default
            new Settings();
           
            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start New game
            StartGame();

        }

        private void StartGame()
        {

            lblGameOver.Visible = false;

            Settings.playerLevel = 1;
            Settings.Speed = 16;
            focus = 0;
            //Set settings to default
            new Settings();

            //Create new player object
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            //Debuff pictures and labels
            overfedPic.Hide();
            overfedlbl.Visible = false;
            headachePic.Hide();
            headachelbl.Visible = false;
            overfedPic.Hide();
            overfedlbl.Visible = false;
            frenzyEffectImage.Hide();
            FrenzyLabel.Visible = false;

            //Ability text indicators
            WraithformPointsCounter.Text = wraith_form_points.ToString();
            focusCounter.Text = focus.ToString();
            movementSpeed.Text = Settings.Speed.ToString();
            lblScore.Text = Settings.Score.ToString();


            //Level indicator
            lvlCounter.Text = Settings.playerLevel.ToString();

                
            GenerateFood();

        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            string temp1 = food.generateNameOfConsumable();

            food = new FoodConsumable { X = random.Next(1, maxXPos - 1), Y = random.Next(1, maxYPos - 1), Name = temp1, Points = food.generatePointsOfConsumable(temp1) };
             

            
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {

                    StartGame();
                }
            }
            else
            {
                if ((Input.KeyPressed(Keys.Right) || Input.KeyPressed(Keys.L)) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if ((Input.KeyPressed(Keys.Left) || Input.KeyPressed(Keys.J)) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if ((Input.KeyPressed(Keys.Up) || Input.KeyPressed(Keys.I)) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if ((Input.KeyPressed(Keys.Down) || Input.KeyPressed(Keys.K)) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                else if (Input.KeyPressed(Keys.Z) && focus > 0)
                {
                
                   
                    combatLog.AppendText("Z" );
                    focus--;

                    combatLog.AppendText("You have gained focus for 2 seconds!\n");

                    Thread.Sleep(2000);
                    
                    focusCounter.Text = focus.ToString();
                    
                } else if (Input.KeyPressed(Keys.X) && wraith_form_points > 0 && wraith_form == false)
                {

                    wraith_form_points--;
                    wraith_form = true;
                    combatLog.AppendText("You have gained wraith form. You may go through yourself for 3 seconds!\n");

                    if(muted == false)
                    {
                       
                        System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer(Properties.Resources.wraith);
                        sp2.Play();
                    }
                    
                }
                else if (Input.KeyPressed(Keys.M))
                {
                    if(muted == false)
                    {
                        muted = true;
                    } else
                    {
                        muted = false;
                    }

                }

                // DISPLAY MUTED ICON IF TRUE
                if (muted)
                {
                    mutedPic.Show();
                    MutedLbl.Visible = true;

                }
                else
                {
                    mutedPic.Hide();
                    MutedLbl.Visible = false;

                }



                MovePlayer();
            }

            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {

                    Brush snakeColour;
                    if (i == 0)
                    {
                        snakeColour = Brushes.Green;     //Draw head
                    }
                    else if (wraith_form == true)
                    {

                        snakeColour = Brushes.LightSkyBlue;

                    } else
                    {

                        snakeColour = Brushes.LightGreen;
                    }




                    //Crtaj zmiju
                    canvas.FillRectangle(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Crtaj hranu

                    if (food.Name.CompareTo("Egg") == 0)
                    {

                        

                        canvas.FillEllipse(Brushes.White,
                        new Rectangle(food.X * Settings.Width,
                        food.Y * Settings.Height, Settings.Width, Settings.Height));


                    }
                    else if (food.Name.CompareTo("Ant") == 0)
                    {

                        canvas.FillEllipse(Brushes.DarkOrange,
                         new Rectangle(food.X * Settings.Width,
                         food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else if (food.Name.CompareTo("Pig") == 0)
                    {

                        canvas.FillEllipse(Brushes.DeepPink,
                         new Rectangle(food.X * Settings.Width,
                         food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else if (food.Name.CompareTo("Boar") == 0)
                    {

                        canvas.FillEllipse(Brushes.SaddleBrown,
                         new Rectangle(food.X * Settings.Width,
                         food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else if (food.Name.CompareTo("Bird") == 0)
                    {

                        canvas.FillEllipse(Brushes.Yellow,
                         new Rectangle(food.X * Settings.Width,
                         food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    
                }
            }

            //GAME OVER

            else
            {

                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress Enter to try again\n";
                lblGameOver.Text = gameOver;
                
                lblGameOver.Visible = true;

            }
        }


        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }



                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Sudaranje sa okvirom
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    if(wraith_form == false)
                    {
                        //Sudaranje sa samim sobom
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].X == Snake[j].X &&
                               Snake[i].Y == Snake[j].Y)
                            {
                                Die();
                            }
                        }

                        

                    } else
                    {
                        moves_made++;
                        var stopwatch = new Stopwatch();
                        stopwatch.Start();
                        int convertmoes = 100 - moves_made * 2;
                        Wraithtimer.Visible = true;
                        wraithformACTIVE.Show();
                        Wraithtimer.Text = convertmoes.ToString();
                        
                    }

                    //50 pixela u wratih formi po bilo  kojoj osi!!!
                    if(moves_made > 50)
                    {
                        
                        moves_made = 0;
                        wraith_form = false;
                        Wraithtimer.Visible = false;
                        wraithformACTIVE.Hide();

                    }

                    
                    focusCounter.Text = focus.ToString();
                    //Detektuje da smo se se sudarili sa hranom
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }


                    WraithformPointsCounter.Text = wraith_form_points.ToString();


                }
                else
                {
                    //Pomjeranje zmije
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

                
               
                


            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            focusCounter.Text = focus.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
            focusCounter.Text = focus.ToString();
        }

        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += food.Points;
            lblScore.Text = Settings.Score.ToString();

            //update combat log
            combatLog.AppendText("You have consumed [" + food.Name + "]" + " and gained: " + food.Points + " points!\n");


            //update lvl
            lvlCounter.Text = Settings.playerLevel.ToString();

            //Update movement speed
            movementSpeed.Text = Settings.Speed.ToString();



            int calc = LevelBar.Value + food.Points;

            int overXP = 0;

            //LEVEL UP
            if (calc > LevelBar.Maximum)
            {

                lvlupsound = true;
                if (muted == false)
                { 
                    System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer(Properties.Resources.lvlup);
                    sp2.Play();
                }

                overXP = calc - LevelBar.Maximum;
                LevelBar.Maximum += 50;

                LevelBar.Value = 0;
                LevelBar.Value += overXP;

                Settings.playerLevel += 1;

                combatLog.AppendText("You have leveled up!\n");
                combatLog.AppendText("Current level:" + Settings.playerLevel + "\n");

                combatLog.AppendText("You have gained 1 [focus] point from leveling up!\n");
                focus++;



            }
            else
            {

                LevelBar.Value += food.Points;
            }


            lvlCounter.Text = Settings.playerLevel.ToString();


            Random r = new Random();

            if (lvlupsound == false && muted == false) { 

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.eatcrunchy);
            sp.Play();
             }
            //FOOD EFFECTS
            if (food.Name == "Boar")
            {
                


                //50% chance to gain Frenzy!
                int chance = r.Next(0,101);

                if(chance <= 50)
                {
                    Settings.Speed = 20;
                    //Frenzy
                    frenzyEffectImage.Show();
                    FrenzyLabel.Visible = true;
                    overfedPic.Hide();
                    overfedlbl.Visible = false;

                    combatLog.AppendText("You have gained [Frenzy]! Movement speed increased!\n");
                }

                headachePic.Hide();
                headachelbl.Visible = false;


            }
            else if (food.Name == "Ant")
            {

                
                int chance = r.Next(0, 101);

                // 33% chance to gain focus!
                if (chance <= 33)
                {
                    
                    focus++;

                    combatLog.AppendText("You have gained 1 [Focus] point from consuming the [Ant]! You may focuse for 2 seconds!\n");
                }

                // 50% chance to remove frenzy!
                if (chance <= 50)
                {
                    Settings.Speed = 16;
                    focusCounter.Text = focus.ToString();
                    frenzyEffectImage.Hide();
                    FrenzyLabel.Visible = false;
                }
                
  
                headachePic.Hide();
                headachelbl.Visible = false;




            }
            else if (food.Name == "Pig")
            {


                int chance = r.Next(0, 101);

                // 10% chance to remove focus
                if (chance <= 10)
                {
                    if(focus > 0)
                    {
                        focus--;
                    }
                    

                    combatLog.AppendText("You have lost 1 [Focus] point from consuming the [Pig]!\n");
                    headachePic.Show();
                    headachelbl.Visible = true;
                   

                }

                // 90% chance to gain overfed
                if (chance <= 90)
                {
                    Settings.Speed = 13;
                    //overfed sript heree
                    overfedPic.Show();
                    overfedlbl.Visible = true;
                    combatLog.AppendText("You gain [Overfed]! Your movement speed has been slowed!\n");
                    frenzyEffectImage.Hide();
                    FrenzyLabel.Visible = false;


                }


            }
            else if (food.Name == "Egg")
            {

                //Completly cures all movement impairing effects and has small chance to give focus!
                int chance = r.Next(0, 101);
                // 5% chance to give focus
                if (chance <= 5)
                {
                    focus++;

                    combatLog.AppendText("You have gained 1 [Focus] point from the [Egg]! You may focuse for 2 seconds!\n");
                    
                }

                Settings.Speed = 16;

                frenzyEffectImage.Hide();
                FrenzyLabel.Visible = false;
                overfedPic.Hide();
                overfedlbl.Visible = false;
                combatLog.AppendText("[Egg] cleared you of all movement impairing effects!\n");
                

                headachePic.Hide();
                headachelbl.Visible = false;


            }
            else if (food.Name == "Bird")
            {

                
                int chance = r.Next(0, 101);
                // 20% chance to give wraith point
                if (chance <= 20)
                {
                    wraith_form_points++;

                    combatLog.AppendText("You have gained 1 [Wraith Point] point from the [Bird]! You may use wraith form for 3 seconds!\n");

                }

                
                
             
               


                


            }
            else
            {

                combatLog.AppendText("NULL");
            }




            gameTimer.Interval = 1000 / Settings.Speed;
            movementSpeed.Text = Settings.Speed.ToString();



            WraithformPointsCounter.Text = wraith_form_points.ToString();

            focusCounter.Text = focus.ToString();

            //generisi hranu na kanvas


            GenerateFood();
            lvlupsound = false;
            
        }

        private void Die()
        {
            Settings.Speed = 16;
            Settings.GameOver = true;

        }

        private void MuteButton_Click(object sender, EventArgs e)
        {


            if(muted == false)
            {
                muted = true;
            } else
            {

                muted = false;

            }



        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }
    }
}
