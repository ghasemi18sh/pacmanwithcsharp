
namespace keyboardgame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.apple3 = new System.Windows.Forms.PictureBox();
            this.snake = new System.Windows.Forms.PictureBox();
            this.apple2 = new System.Windows.Forms.PictureBox();
            this.apple1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.apple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            this.SuspendLayout();
            // 
            // apple3
            // 
            this.apple3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple3.BackgroundImage")));
            this.apple3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apple3.Location = new System.Drawing.Point(559, 145);
            this.apple3.Name = "apple3";
            this.apple3.Size = new System.Drawing.Size(95, 75);
            this.apple3.TabIndex = 0;
            this.apple3.TabStop = false;
            this.apple3.Tag = "ghost";
            // 
            // snake
            // 
            this.snake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snake.BackgroundImage")));
            this.snake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.snake.Location = new System.Drawing.Point(88, 183);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(81, 75);
            this.snake.TabIndex = 1;
            this.snake.TabStop = false;
            // 
            // apple2
            // 
            this.apple2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple2.BackgroundImage")));
            this.apple2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apple2.Location = new System.Drawing.Point(260, 240);
            this.apple2.Name = "apple2";
            this.apple2.Size = new System.Drawing.Size(77, 75);
            this.apple2.TabIndex = 2;
            this.apple2.TabStop = false;
            this.apple2.Tag = "ghost";
            // 
            // apple1
            // 
            this.apple1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple1.BackgroundImage")));
            this.apple1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apple1.Location = new System.Drawing.Point(287, 22);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(87, 75);
            this.apple1.TabIndex = 4;
            this.apple1.TabStop = false;
            this.apple1.Tag = "ghost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apple1);
            this.Controls.Add(this.apple2);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.apple3);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.apple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox apple3;
        private System.Windows.Forms.PictureBox snake;
        private System.Windows.Forms.PictureBox apple2;
        private System.Windows.Forms.PictureBox apple1;
        private System.Windows.Forms.Timer timer1;
    }
}

