namespace CalorieCounterConverter
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
            this.fatGramsTextBox = new System.Windows.Forms.TextBox();
            this.gramsCarbsTextBox = new System.Windows.Forms.TextBox();
            this.gramsOfFatLabel = new System.Windows.Forms.Label();
            this.gramsOfCarbs = new System.Windows.Forms.Label();
            this.displayCaloriesFromFats = new System.Windows.Forms.Label();
            this.displayCaloriesFromCarbs = new System.Windows.Forms.Label();
            this.displayTotalCalories = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convertedFats = new System.Windows.Forms.Label();
            this.convertedCarbsLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fatGramsTextBox
            // 
            this.fatGramsTextBox.Location = new System.Drawing.Point(379, 87);
            this.fatGramsTextBox.Name = "fatGramsTextBox";
            this.fatGramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatGramsTextBox.TabIndex = 0;
            // 
            // gramsCarbsTextBox
            // 
            this.gramsCarbsTextBox.Location = new System.Drawing.Point(379, 151);
            this.gramsCarbsTextBox.Name = "gramsCarbsTextBox";
            this.gramsCarbsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gramsCarbsTextBox.TabIndex = 1;
            // 
            // gramsOfFatLabel
            // 
            this.gramsOfFatLabel.AutoSize = true;
            this.gramsOfFatLabel.Location = new System.Drawing.Point(152, 90);
            this.gramsOfFatLabel.Name = "gramsOfFatLabel";
            this.gramsOfFatLabel.Size = new System.Drawing.Size(70, 13);
            this.gramsOfFatLabel.TabIndex = 2;
            this.gramsOfFatLabel.Text = "Grams of Fat:";
            // 
            // gramsOfCarbs
            // 
            this.gramsOfCarbs.AutoSize = true;
            this.gramsOfCarbs.Location = new System.Drawing.Point(152, 154);
            this.gramsOfCarbs.Name = "gramsOfCarbs";
            this.gramsOfCarbs.Size = new System.Drawing.Size(82, 13);
            this.gramsOfCarbs.TabIndex = 3;
            this.gramsOfCarbs.Text = "Grams of Carbs:";
            // 
            // displayCaloriesFromFats
            // 
            this.displayCaloriesFromFats.AutoSize = true;
            this.displayCaloriesFromFats.Location = new System.Drawing.Point(6, 16);
            this.displayCaloriesFromFats.Name = "displayCaloriesFromFats";
            this.displayCaloriesFromFats.Size = new System.Drawing.Size(35, 13);
            this.displayCaloriesFromFats.TabIndex = 4;
            this.displayCaloriesFromFats.Text = "label1";
            // 
            // displayCaloriesFromCarbs
            // 
            this.displayCaloriesFromCarbs.AutoSize = true;
            this.displayCaloriesFromCarbs.Location = new System.Drawing.Point(6, 38);
            this.displayCaloriesFromCarbs.Name = "displayCaloriesFromCarbs";
            this.displayCaloriesFromCarbs.Size = new System.Drawing.Size(35, 13);
            this.displayCaloriesFromCarbs.TabIndex = 5;
            this.displayCaloriesFromCarbs.Text = "label1";
            // 
            // displayTotalCalories
            // 
            this.displayTotalCalories.AutoSize = true;
            this.displayTotalCalories.Location = new System.Drawing.Point(6, 74);
            this.displayTotalCalories.Name = "displayTotalCalories";
            this.displayTotalCalories.Size = new System.Drawing.Size(35, 13);
            this.displayTotalCalories.TabIndex = 6;
            this.displayTotalCalories.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayCaloriesFromFats);
            this.groupBox1.Controls.Add(this.displayTotalCalories);
            this.groupBox1.Controls.Add(this.displayCaloriesFromCarbs);
            this.groupBox1.Location = new System.Drawing.Point(379, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // convertedFats
            // 
            this.convertedFats.AutoSize = true;
            this.convertedFats.Location = new System.Drawing.Point(273, 232);
            this.convertedFats.Name = "convertedFats";
            this.convertedFats.Size = new System.Drawing.Size(93, 13);
            this.convertedFats.TabIndex = 8;
            this.convertedFats.Text = "Calories from Fats:";
            // 
            // convertedCarbsLabel
            // 
            this.convertedCarbsLabel.AutoSize = true;
            this.convertedCarbsLabel.Location = new System.Drawing.Point(273, 254);
            this.convertedCarbsLabel.Name = "convertedCarbsLabel";
            this.convertedCarbsLabel.Size = new System.Drawing.Size(100, 13);
            this.convertedCarbsLabel.TabIndex = 9;
            this.convertedCarbsLabel.Text = "Calories from Carbs:";
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(273, 290);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(74, 13);
            this.totalCaloriesLabel.TabIndex = 10;
            this.totalCaloriesLabel.Text = "Total Calories:";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(155, 365);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 11;
            this.totalButton.Text = "&Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 365);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(420, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.convertedCarbsLabel);
            this.Controls.Add(this.convertedFats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gramsOfCarbs);
            this.Controls.Add(this.gramsOfFatLabel);
            this.Controls.Add(this.gramsCarbsTextBox);
            this.Controls.Add(this.fatGramsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fatGramsTextBox;
        private System.Windows.Forms.TextBox gramsCarbsTextBox;
        private System.Windows.Forms.Label gramsOfFatLabel;
        private System.Windows.Forms.Label gramsOfCarbs;
        private System.Windows.Forms.Label displayCaloriesFromFats;
        private System.Windows.Forms.Label displayCaloriesFromCarbs;
        private System.Windows.Forms.Label displayTotalCalories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label convertedFats;
        private System.Windows.Forms.Label convertedCarbsLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

