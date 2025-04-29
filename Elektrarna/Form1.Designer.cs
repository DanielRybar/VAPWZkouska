namespace Elektrarna
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
            powerSourceUserControl1 = new Elektrarna.Components.PowerSourceUserControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // powerSourceUserControl1
            // 
            powerSourceUserControl1.BorderStyle = BorderStyle.FixedSingle;
            powerSourceUserControl1.Location = new Point(837, 12);
            powerSourceUserControl1.Name = "powerSourceUserControl1";
            powerSourceUserControl1.Size = new Size(260, 293);
            powerSourceUserControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(819, 432);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 462);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1154, 503);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(powerSourceUserControl1);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.PowerSourceUserControl powerSourceUserControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}
