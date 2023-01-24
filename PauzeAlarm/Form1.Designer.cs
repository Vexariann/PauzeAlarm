namespace PauzeAlarm
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
            this.TimePickerLabel = new System.Windows.Forms.Label();
            this.TimeSelector = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.PauzeList = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountdownText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimePickerLabel
            // 
            this.TimePickerLabel.AutoSize = true;
            this.TimePickerLabel.Location = new System.Drawing.Point(12, 29);
            this.TimePickerLabel.Name = "TimePickerLabel";
            this.TimePickerLabel.Size = new System.Drawing.Size(34, 20);
            this.TimePickerLabel.TabIndex = 1;
            this.TimePickerLabel.Text = "Tijd";
            // 
            // TimeSelector
            // 
            this.TimeSelector.CustomFormat = "HH:mm tt";
            this.TimeSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeSelector.Location = new System.Drawing.Point(67, 22);
            this.TimeSelector.Name = "TimeSelector";
            this.TimeSelector.ShowUpDown = true;
            this.TimeSelector.Size = new System.Drawing.Size(107, 27);
            this.TimeSelector.TabIndex = 2;
            this.TimeSelector.Value = new System.DateTime(2023, 1, 24, 11, 57, 55, 0);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 93);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 29);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Voeg pauze toe";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PauzeList
            // 
            this.PauzeList.FormattingEnabled = true;
            this.PauzeList.ItemHeight = 20;
            this.PauzeList.Location = new System.Drawing.Point(12, 134);
            this.PauzeList.Name = "PauzeList";
            this.PauzeList.Size = new System.Drawing.Size(283, 284);
            this.PauzeList.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(67, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(165, 27);
            this.NameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Als je een pauze wilt verwijderen. Selecteer hem en druk op DEL";
            // 
            // CountdownText
            // 
            this.CountdownText.AutoSize = true;
            this.CountdownText.Location = new System.Drawing.Point(307, 9);
            this.CountdownText.Name = "CountdownText";
            this.CountdownText.Size = new System.Drawing.Size(137, 20);
            this.CountdownText.TabIndex = 8;
            this.CountdownText.Text = "60s until next check";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.CountdownText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PauzeList);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeSelector);
            this.Controls.Add(this.TimePickerLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TimePickerLabel;
        private DateTimePicker TimeSelector;
        private Button AddButton;
        private ListBox PauzeList;
        private TextBox NameTextBox;
        private Label label1;
        private Label label2;
        private Label CountdownText;
    }
}