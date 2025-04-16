namespace Hladina
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
            nadrz1 = new Hladina.Components.Nadrz();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // nadrz1
            // 
            nadrz1.ColumnCount = 1;
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nadrz1.Location = new Point(59, 62);
            nadrz1.Name = "nadrz1";
            nadrz1.RowCount = 1;
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nadrz1.Size = new Size(194, 323);
            nadrz1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(483, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Akce";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(nadrz1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.Nadrz nadrz1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
