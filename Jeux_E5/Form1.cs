using System.Numerics;
using System;
using System.Text;
using System.Media;
using Jeux_E5.Properties;
using System.Threading;

namespace Jeux_E5
{
    public partial class OctopathE5 : Form
    {
        private Player player;
        private Monster monster;
        private string actionText;
        private StringBuilder animatedText;
        private int textAnimationFrame;
        private bool isPlayerTurn;
        private Random random = new Random();
        private bool gameOver = false;
        public event EventHandler GameOver;




        private void playSimpleSound(string file)
        {
            SoundPlayer simpleSound = new SoundPlayer(file);
            simpleSound.Play();
        }
        private void EnableButtons(bool enable)
        {
            attackButton.Enabled = enable;
            healButton.Enabled = enable;
            doubleAttackButton.Enabled = enable;
        }
        private void LoadAnimatedGif(string filePath)
        {
            Cloud.Load(filePath);
        }

        private void AnimateText(string text)
        {
            actionText = text;
            animatedText = new StringBuilder();
            textAnimationFrame = 0;
            textAnimationTimer.Start();
        }
        private void UpdateHealthBars()
        {
            playerHealthBar.Value = player.Health;
            monsterHealthBar.Value = monster.Health;
            UpdateStats();
        }
        private void UpdateStats()
        {
            lblPlayerStats.Text = $"HP: {player.Health} / {player.MaxHealth} - Mana: {player.Mana} / {player.MaxMana}";
            lblMonsterStats.Text = $"HP: {monster.Health} / {monster.MaxHealth}";

        }

        private void InitializeGame()
        {
            player = new Player("Cloud", 100, 20, 30, 100);
            monster = new Monster("Dracky", 200, 15, 20);

            playerNameLabel.Text = player.Name;
            playerHealthBar.Maximum = player.MaxHealth;
            playerHealthBar.Value = player.Health;

            monsterNameLabel.Text = monster.Name;
            monsterHealthBar.Maximum = monster.MaxHealth;
            monsterHealthBar.Value = monster.Health;
            UpdateStats();
            textAnimationTimer.Interval = 30; // Vitesse d'animation du texte
            textAnimationTimer.Tick += TextAnimationTimer_Tick;

            AnimateText("Le combat commence !");
            EnableButtons(true);
        }

        private void PlayerTurn()
        {
            var attackResult = player.Attack(monster);

            if (attackResult.Item1)
            {
                AnimateText($"{player.Name} attaque {monster.Name} et inflige {attackResult.Item2} points de dégâts !");
            }
            else
            {
                AnimateText($"{player.Name} attaque {monster.Name} mais rate son attaque !");
            }

            if (monster.Health <= 0)
            {
                return;
            }
            else
            {
                isPlayerTurn = true;
            }

            UpdateHealthBars();
        }

        private void EnemyTurn()
        {

            // Choisir une action pour le monstre
            int monsterAction = random.Next(0, 100);

            if (monsterAction < 20) // 20% de chance d'utiliser Enrage
            {
                monster.Enrage();
                AnimateText($"Le {monster.Name} entre dans une rage !");
            }
            else // 80% de chance d'attaquer normalement
            {
                int damageDealt = monster.Attack(player).Item2;
                if (damageDealt > 0)
                {
                    AnimateText($"Le {monster.Name} inflige {damageDealt} points de dégâts !");
                }
                else
                {
                    AnimateText($"Le {monster.Name} rate son attaque !");
                }
            }

            UpdateHealthBars();
        }

        private void TextAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (textAnimationFrame < actionText.Length)
            {
                animatedText.Append(actionText[textAnimationFrame]);
                actionLabel.Text = animatedText.ToString();
                textAnimationFrame++;
            }
            else
            {
                textAnimationTimer.Stop();

                if (!isPlayerTurn)
                {
                    isPlayerTurn = true;
                    EnableButtons(true); // Activer les boutons
                }
                else
                {
                    CheckGameOver();
                    if (!gameOver)
                    {
                        isPlayerTurn = false;
                        EnemyTurn();
                        CheckGameOver();
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public OctopathE5()
        {
            InitializeComponent();
            GameOver += MainForm_GameOver; // S'abonner à l'événement GameOver
            InitializeGame();
            playSimpleSound("C:\\Users\\Administrator\\Source\\Repos\\StephD974\\OctopathE5\\Jeux_E5\\Resources\\let-the-battles-begin.wav");
        }

        private void attackButton_Click_1(object sender, EventArgs e)
        {
            EnableButtons(false); // Désactiver les boutons
            PlayerTurn();
            CheckGameOver();
        }

        private void doubleAttackButton_Click(object sender, EventArgs e)
        {
            if (player.Mana >= 50)
            {
                EnableButtons(false); // Désactiver les boutons
                player.DoubleAttack(monster, 50);
                CheckGameOver();
                AnimateText($"{player.Name} effectue une double attaque !");
                UpdateHealthBars();
            }
            else
            {
                AnimateText("Pas assez de mana pour effectuer une double attaque !");
                PlayerTurn();

            }
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            EnableButtons(false); // Désactiver les boutons
            player.Heal();
            AnimateText($"{player.Name} se soigne !");
            UpdateHealthBars();
        }

        private void CheckGameOver()
        {
            if (monster.Health <= 0)
            {
                playSimpleSound("C:\\Users\\Administrator\\Source\\Repos\\StephD974\\OctopathE5\\Jeux_E5\\Resources\\victory-fanfare-hd.wav");
                LoadAnimatedGif("C:\\Users\\Administrator\\Source\\Repos\\StephD974\\OctopathE5\\Jeux_E5\\Resources\\207000106 Win Before.gif");

                GameOverDialog($"{player.Name} a vaincu le monstre ! Félicitations !");
            }
            else if (player.Health <= 0)
            {
                GameOverDialog("Le monstre a vaincu le joueur. Essayez à nouveau.");
            }
        }

        private void GameOverDialog(string message)
        {
            gameOver = true;
            textAnimationTimer.Stop();

            DialogResult result = MessageBox.Show(message + " Voulez-vous recommencer ?", "Fin du jeu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }



        private async void ResetGame()
        {
            // Réinitialiser l'interface utilisateur
            gameOver = false;
            player.ResetStats();
            monster.ResetStats();
            UpdateHealthBars();
            playSimpleSound("C:\\Users\\Administrator\\Source\\Repos\\StephD974\\OctopathE5\\Jeux_E5\\Resources\\let-the-battles-begin.wav"); // Remplacez par le chemin du fichier audio normal
            LoadAnimatedGif("C:\\Users\\Administrator\\Source\\Repos\\StephD974\\OctopathE5\\Jeux_E5\\Resources\\207000106 Idle.gif"); // Remplacez par le chemin du fichier GIF animé normal

            await Task.Delay(1000); // Attendez 1 seconde avant de commencer le nouveau combat
            AnimateText("Un nouveau combat commence !");
            textAnimationTimer.Start();
        }

        private void MainForm_GameOver(object sender, EventArgs e)
        {
            ResetGame(); // Appeler ResetGame() lorsque l'événement GameOver est déclenché
        }
    }

}