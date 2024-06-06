namespace OverwatchCounters
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DVA", "DOOMFIST", "JUNKER QUEEN", "MAUGA", "ORISA", "RAMATTRA", "REINHARDT", "ROADHOG", "SIGMA", "WINSTON", "WRECKING BALL", "ZARYA", "ASHE", "BASTION", "CASSIDY", "ECHO", "GENJI", "HANZO", "JUNKRAT", "MEI", "PHARAH", "REAPER", "SOJOURN", "SOLDIER: 67", "SOMBRA", "SYMMETRA", "TORBJORN", "TRACER", "VENTURE", "WIDOWMAKER", "ANA", "BAPISTE", "BRIGITTE", "ILLARY", "KIRIKO", "LIFEWEAVER", "LUCIO", "MERCY", "MOIRA", "ZENYATTA" });
            comboBox1.Location = new Point(287, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(184, 220);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "You're Hero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(184, 288);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Selected: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(247, 288);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 3;
            label3.Text = "?";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Highlight;
            listView1.Location = new Point(497, 217);
            listView1.Name = "listView1";
            listView1.Size = new Size(331, 281);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(471, 187);
            label4.Name = "label4";
            label4.Size = new Size(446, 15);
            label4.TabIndex = 5;
            label4.Text = "IMPORTANT: AFTER 10 SECONDS THE COUNTERS WILL DELETED IN THE MENU.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1112, 635);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Overwatch Counters";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private Label label4;
    }
}
