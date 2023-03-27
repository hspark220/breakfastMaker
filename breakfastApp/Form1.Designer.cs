namespace breakfastApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.makeBreakfast = new System.Windows.Forms.Button();
            this.coffeeBox = new System.Windows.Forms.TextBox();
            this.toastBox = new System.Windows.Forms.TextBox();
            this.eggBox = new System.Windows.Forms.TextBox();
            this.baconBox = new System.Windows.Forms.TextBox();
            this.orangeJuice = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.orangeJuice2 = new System.Windows.Forms.TextBox();
            this.baconBox2 = new System.Windows.Forms.TextBox();
            this.eggBox2 = new System.Windows.Forms.TextBox();
            this.toastBox2 = new System.Windows.Forms.TextBox();
            this.coffeeBox2 = new System.Windows.Forms.TextBox();
            this.makeConcurrent = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.orangeJuice3 = new System.Windows.Forms.TextBox();
            this.baconBox3 = new System.Windows.Forms.TextBox();
            this.eggBox3 = new System.Windows.Forms.TextBox();
            this.toastBox3 = new System.Windows.Forms.TextBox();
            this.coffeeBox3 = new System.Windows.Forms.TextBox();
            this.makeAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeBreakfast
            // 
            this.makeBreakfast.Location = new System.Drawing.Point(50, 50);
            this.makeBreakfast.Name = "makeBreakfast";
            this.makeBreakfast.Size = new System.Drawing.Size(100, 40);
            this.makeBreakfast.TabIndex = 0;
            this.makeBreakfast.Text = "make breakfast (no threading)";
            this.makeBreakfast.UseVisualStyleBackColor = true;
            this.makeBreakfast.Click += new System.EventHandler(this.makeBreakfast_Click);
            // 
            // coffeeBox
            // 
            this.coffeeBox.Location = new System.Drawing.Point(50, 100);
            this.coffeeBox.Name = "coffeeBox";
            this.coffeeBox.Size = new System.Drawing.Size(100, 20);
            this.coffeeBox.TabIndex = 1;
            this.coffeeBox.Text = "Coffee";
            this.coffeeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toastBox
            // 
            this.toastBox.Location = new System.Drawing.Point(50, 190);
            this.toastBox.Name = "toastBox";
            this.toastBox.Size = new System.Drawing.Size(100, 20);
            this.toastBox.TabIndex = 2;
            this.toastBox.Text = "Toast";
            this.toastBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eggBox
            // 
            this.eggBox.Location = new System.Drawing.Point(50, 130);
            this.eggBox.Name = "eggBox";
            this.eggBox.Size = new System.Drawing.Size(100, 20);
            this.eggBox.TabIndex = 3;
            this.eggBox.Text = "Egg";
            this.eggBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baconBox
            // 
            this.baconBox.Location = new System.Drawing.Point(50, 160);
            this.baconBox.Name = "baconBox";
            this.baconBox.Size = new System.Drawing.Size(100, 20);
            this.baconBox.TabIndex = 4;
            this.baconBox.Text = "Bacon";
            this.baconBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orangeJuice
            // 
            this.orangeJuice.Location = new System.Drawing.Point(50, 220);
            this.orangeJuice.Name = "orangeJuice";
            this.orangeJuice.Size = new System.Drawing.Size(100, 20);
            this.orangeJuice.TabIndex = 5;
            this.orangeJuice.Text = "OJ";
            this.orangeJuice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 250);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 20);
            this.progressBar.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(203, 250);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 20);
            this.progressBar2.TabIndex = 13;
            // 
            // orangeJuice2
            // 
            this.orangeJuice2.Location = new System.Drawing.Point(203, 220);
            this.orangeJuice2.Name = "orangeJuice2";
            this.orangeJuice2.Size = new System.Drawing.Size(100, 20);
            this.orangeJuice2.TabIndex = 12;
            this.orangeJuice2.Text = "OJ";
            this.orangeJuice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baconBox2
            // 
            this.baconBox2.Location = new System.Drawing.Point(203, 160);
            this.baconBox2.Name = "baconBox2";
            this.baconBox2.Size = new System.Drawing.Size(100, 20);
            this.baconBox2.TabIndex = 11;
            this.baconBox2.Text = "Bacon";
            this.baconBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eggBox2
            // 
            this.eggBox2.Location = new System.Drawing.Point(203, 130);
            this.eggBox2.Name = "eggBox2";
            this.eggBox2.Size = new System.Drawing.Size(100, 20);
            this.eggBox2.TabIndex = 10;
            this.eggBox2.Text = "Egg";
            this.eggBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toastBox2
            // 
            this.toastBox2.Location = new System.Drawing.Point(203, 190);
            this.toastBox2.Name = "toastBox2";
            this.toastBox2.Size = new System.Drawing.Size(100, 20);
            this.toastBox2.TabIndex = 9;
            this.toastBox2.Text = "Toast";
            this.toastBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coffeeBox2
            // 
            this.coffeeBox2.Location = new System.Drawing.Point(203, 100);
            this.coffeeBox2.Name = "coffeeBox2";
            this.coffeeBox2.Size = new System.Drawing.Size(100, 20);
            this.coffeeBox2.TabIndex = 8;
            this.coffeeBox2.Text = "Coffee";
            this.coffeeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeConcurrent
            // 
            this.makeConcurrent.Location = new System.Drawing.Point(203, 50);
            this.makeConcurrent.Name = "makeConcurrent";
            this.makeConcurrent.Size = new System.Drawing.Size(100, 40);
            this.makeConcurrent.TabIndex = 7;
            this.makeConcurrent.Text = "make breakfast (concurrently)";
            this.makeConcurrent.UseVisualStyleBackColor = true;
            this.makeConcurrent.Click += new System.EventHandler(this.makeConcurrent_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(366, 250);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 20);
            this.progressBar3.TabIndex = 20;
            // 
            // orangeJuice3
            // 
            this.orangeJuice3.Location = new System.Drawing.Point(366, 220);
            this.orangeJuice3.Name = "orangeJuice3";
            this.orangeJuice3.Size = new System.Drawing.Size(100, 20);
            this.orangeJuice3.TabIndex = 19;
            this.orangeJuice3.Text = "OJ";
            this.orangeJuice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baconBox3
            // 
            this.baconBox3.Location = new System.Drawing.Point(366, 160);
            this.baconBox3.Name = "baconBox3";
            this.baconBox3.Size = new System.Drawing.Size(100, 20);
            this.baconBox3.TabIndex = 18;
            this.baconBox3.Text = "Bacon";
            this.baconBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eggBox3
            // 
            this.eggBox3.Location = new System.Drawing.Point(366, 130);
            this.eggBox3.Name = "eggBox3";
            this.eggBox3.Size = new System.Drawing.Size(100, 20);
            this.eggBox3.TabIndex = 17;
            this.eggBox3.Text = "Egg";
            this.eggBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toastBox3
            // 
            this.toastBox3.Location = new System.Drawing.Point(366, 190);
            this.toastBox3.Name = "toastBox3";
            this.toastBox3.Size = new System.Drawing.Size(100, 20);
            this.toastBox3.TabIndex = 16;
            this.toastBox3.Text = "Toast";
            this.toastBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coffeeBox3
            // 
            this.coffeeBox3.Location = new System.Drawing.Point(366, 100);
            this.coffeeBox3.Name = "coffeeBox3";
            this.coffeeBox3.Size = new System.Drawing.Size(100, 20);
            this.coffeeBox3.TabIndex = 15;
            this.coffeeBox3.Text = "Coffee";
            this.coffeeBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeAsync
            // 
            this.makeAsync.Location = new System.Drawing.Point(366, 50);
            this.makeAsync.Name = "makeAsync";
            this.makeAsync.Size = new System.Drawing.Size(100, 40);
            this.makeAsync.TabIndex = 14;
            this.makeAsync.Text = "make breakfast (effeciently)";
            this.makeAsync.UseVisualStyleBackColor = true;
            this.makeAsync.Click += new System.EventHandler(this.makeAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.orangeJuice3);
            this.Controls.Add(this.baconBox3);
            this.Controls.Add(this.eggBox3);
            this.Controls.Add(this.toastBox3);
            this.Controls.Add(this.coffeeBox3);
            this.Controls.Add(this.makeAsync);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.orangeJuice2);
            this.Controls.Add(this.baconBox2);
            this.Controls.Add(this.eggBox2);
            this.Controls.Add(this.toastBox2);
            this.Controls.Add(this.coffeeBox2);
            this.Controls.Add(this.makeConcurrent);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.orangeJuice);
            this.Controls.Add(this.baconBox);
            this.Controls.Add(this.eggBox);
            this.Controls.Add(this.toastBox);
            this.Controls.Add(this.coffeeBox);
            this.Controls.Add(this.makeBreakfast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeBreakfast;
        private System.Windows.Forms.TextBox coffeeBox;
        private System.Windows.Forms.TextBox toastBox;
        private System.Windows.Forms.TextBox eggBox;
        private System.Windows.Forms.TextBox baconBox;
        private System.Windows.Forms.TextBox orangeJuice;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox orangeJuice2;
        private System.Windows.Forms.TextBox baconBox2;
        private System.Windows.Forms.TextBox eggBox2;
        private System.Windows.Forms.TextBox toastBox2;
        private System.Windows.Forms.TextBox coffeeBox2;
        private System.Windows.Forms.Button makeConcurrent;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox orangeJuice3;
        private System.Windows.Forms.TextBox baconBox3;
        private System.Windows.Forms.TextBox eggBox3;
        private System.Windows.Forms.TextBox toastBox3;
        private System.Windows.Forms.TextBox coffeeBox3;
        private System.Windows.Forms.Button makeAsync;
    }
}

