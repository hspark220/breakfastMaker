using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breakfastApp
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void makeBreakfast_Click(object sender, EventArgs e)
        {
            Coffee cup = PourCoffee(coffeeBox, progressBar);
            coffeeBox.BackColor = Color.Green;

            Egg eggs = FryEggs(2, eggBox, progressBar);
            eggBox.BackColor = Color.Green;

            Bacon bacon = FryBacon(3, baconBox, progressBar);
            baconBox.BackColor = Color.Green;

            Toast toast = ToastBread(2, toastBox, progressBar);
            ApplyButter(toast, toastBox, progressBar);
            ApplyJam(toast, toastBox, progressBar);
            toastBox.BackColor = Color.Green;

            Juice oj = PourOJ(orangeJuice, progressBar);
            orangeJuice.BackColor = Color.Green;

        }

        private static Juice PourOJ(TextBox orangeJuice, ProgressBar progressBar)
        {
            orangeJuice.Text = "Done!";
            progressBar.Value += 20;
            return new Juice();
        }


        private static void ApplyJam(Toast toast, TextBox toastBox, ProgressBar progressBar)
        {
            progressBar.Value += 5 ;
            toastBox.Text = "Jam!";
        }
        private static void ApplyButter(Toast toast, TextBox toastBox, ProgressBar progressBar)
        {
            progressBar.Value += 5;
            toastBox.Text = "Butter!";
        }
        private static Toast ToastBread(int slices, TextBox toastBox, ProgressBar progressBar)
        {
            toastBox.Text = "Starting...";
            Task.Delay(3000).Wait();
            toastBox.Text = "Done!";
            progressBar.Value += 10;
            return new Toast();
        }

        private static Bacon FryBacon(int slices, TextBox baconBox, ProgressBar progressBar)
        {
            baconBox.Text = $"cooking {slices}";
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                baconBox.Text = $"flipping {slice}";
            }
            Task.Delay(3000).Wait();
            baconBox.Text = "Done!";
            progressBar.Value += 20;
            return new Bacon();
        }
        private static Egg FryEggs(int howMany, TextBox eggBox, ProgressBar progressBar)
        {
            eggBox.Text = "warming pan...";
            Task.Delay(3000).Wait();
            eggBox.Text = $"craking {howMany} eggs";
            Task.Delay(3000).Wait();
            eggBox.Text = "Done!";
            progressBar.Value += 20;
            return new Egg();
        }
        private static Coffee PourCoffee(TextBox coffeeBox, ProgressBar progressBar)
        {
            coffeeBox.Text = "Done!";
            progressBar.Value += 20;
            return new Coffee();
        }

        private async void makeConcurrent_Click(object sender, EventArgs e)
        {
            Coffee cup = PourCoffee(coffeeBox2, progressBar2);
            coffeeBox2.BackColor = Color.Green;

            Task<Egg> eggsTask = FryEggsAsync(2, eggBox2, progressBar2);
            Egg eggs = await eggsTask;
            eggBox2.BackColor = Color.Green;

            Task<Bacon> baconTask = FryBaconAsync(3, baconBox2, progressBar2);
            Bacon bacon = await baconTask;
            baconBox2.BackColor = Color.Green;

            Task<Toast> toastTask = ToastBreadAsync(2, toastBox2, progressBar2);
            Toast toast = await toastTask;
            ApplyButterAsync(toast, toastBox2, progressBar2);
            ApplyJamAsync(toast, toastBox2, progressBar2);
            toastBox2.BackColor = Color.Green;

            Juice oj = PourOJ(orangeJuice2, progressBar2);
            orangeJuice2.BackColor = Color.Green;
        }

        private static Juice PourOJAsync(TextBox orangeJuice, ProgressBar progressBar)
        {
            orangeJuice.Text = "Done!";
            progressBar.Value += 20;
            return new Juice();
        }


        private static  void ApplyJamAsync(Toast toast, TextBox toastBox, ProgressBar progressBar)
        {
            progressBar.Value += 5;
            toastBox.Text = "Jam!";
        }
        private static void ApplyButterAsync(Toast toast, TextBox toastBox, ProgressBar progressBar)
        {
            progressBar.Value += 5;
            toastBox.Text = "Butter!";
        }
        private static async Task<Toast> ToastBreadAsync(int slices, TextBox toastBox, ProgressBar progressBar)
        {
            toastBox.Text = "Starting...";
            await Task.Delay(3000);
            toastBox.Text = "Done!";
            progressBar.Value += 10;
            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices, TextBox baconBox, ProgressBar progressBar)
        {
            baconBox.Text = $"cooking {slices}";
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                baconBox.Text = $"flipping {slice}";
            }
            await Task.Delay(3000);
            baconBox.Text = "Done!";
            progressBar.Value += 20;
            return new Bacon();
        }
        private static async Task<Egg> FryEggsAsync(int howMany, TextBox eggBox, ProgressBar progressBar)
        {
            eggBox.Text = "warming pan...";
            await Task.Delay(3000);
            eggBox.Text = $"craking {howMany} eggs";
            await Task.Delay(3000);
            eggBox.Text = "Done!";
            progressBar.Value += 20;
            return new Egg();
        }
        private static Coffee PourCoffeeAsync(TextBox coffeeBox, ProgressBar progressBar)
        {
            coffeeBox.Text = "Done!";
            progressBar.Value += 20;
            return new Coffee();
        }

        private async void makeAsync_Click(object sender, EventArgs e)
        {
            Coffee cup = PourCoffee(coffeeBox3, progressBar3);
            coffeeBox3.BackColor = Color.Green;

            var eggsTask = FryEggsAsync(2, eggBox3, progressBar3);
            var baconTask = FryBaconAsync(3, baconBox3, progressBar3);
            var toastTask = MakeToastWithButterAndJamAsync(2, toastBox3, progressBar3);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    eggBox3.BackColor = Color.Green;
                }
                else if (finishedTask == baconTask)
                {
                    baconBox3.BackColor = Color.Green;
                }
                else if (finishedTask == toastTask)
                {
                    toastBox3.BackColor = Color.Green;
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ(orangeJuice3, progressBar3);
            orangeJuice3.BackColor = Color.Green;
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number, TextBox toastBox, ProgressBar progressBar)
        {
            var toast = await ToastBreadAsync(number, toastBox, progressBar);
            ApplyButter(toast, toastBox, progressBar);
            ApplyJam(toast, toastBox, progressBar);

            return toast;
        }
    }
}
