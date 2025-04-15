namespace Semafor
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
            components = new System.ComponentModel.Container();
            semafor1 = new Semafor.Components.Semaphore();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            semafor2 = new Semafor.Components.Semaphore();
            SuspendLayout();
            // 
            // semafor1
            // 
            semafor1.ColumnCount = 1;
            semafor1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            semafor1.Location = new Point(46, 49);
            semafor1.Name = "semafor1";
            semafor1.RowCount = 3;
            semafor1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            semafor1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            semafor1.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            semafor1.Size = new Size(154, 341);
            // 
            // timer1
            // 
            timer1.Interval = 500;
            // 
            // button1
            // 
            button1.Location = new Point(343, 207);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Akce";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // semafor2
            // 
            semafor2.ColumnCount = 1;
            semafor2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            semafor2.Location = new Point(574, 49);
            semafor2.Name = "semafor2";
            semafor2.RowCount = 3;
            semafor2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            semafor2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            semafor2.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            semafor2.Size = new Size(154, 341);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(semafor2);
            Controls.Add(button1);
            Controls.Add(semafor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.Semaphore semafor1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Components.Semaphore semafor2;
    }
}