namespace PictureBoxDemo
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBoxUserControl1 = new PictureBoxDemo.Components.PictureBoxUserControl();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pictureBoxUserControl1
            // 
            pictureBoxUserControl1.Location = new Point(1, 12);
            pictureBoxUserControl1.Name = "pictureBoxUserControl1";
            pictureBoxUserControl1.Size = new Size(787, 426);
            pictureBoxUserControl1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxUserControl1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Components.PictureBoxUserControl pictureBoxUserControl1;
        private System.Windows.Forms.Timer timer1;
    }
}