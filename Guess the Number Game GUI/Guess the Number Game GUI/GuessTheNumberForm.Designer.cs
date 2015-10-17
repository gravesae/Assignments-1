﻿namespace Guess_the_Number_Game_GUI
{
   partial class GuessTheNumberForm
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
         this.statusLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.playAgainButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // statusLabel
         // 
         this.statusLabel.BackColor = System.Drawing.Color.White;
         this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statusLabel.Location = new System.Drawing.Point(40, 25);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(567, 50);
         this.statusLabel.TabIndex = 0;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.inputTextBox.Location = new System.Drawing.Point(247, 161);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(132, 33);
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // playAgainButton
         // 
         this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.playAgainButton.Location = new System.Drawing.Point(226, 265);
         this.playAgainButton.Name = "playAgainButton";
         this.playAgainButton.Size = new System.Drawing.Size(187, 54);
         this.playAgainButton.TabIndex = 3;
         this.playAgainButton.Text = "Play Again?";
         this.playAgainButton.UseVisualStyleBackColor = true;
         this.playAgainButton.Visible = false;
         this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
         // 
         // GuessTheNumberForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(661, 387);
         this.Controls.Add(this.playAgainButton);
         this.Controls.Add(this.inputTextBox);
         this.Controls.Add(this.statusLabel);
         this.Name = "GuessTheNumberForm";
         this.Text = "Guess the Number Game";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label statusLabel;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.Button playAgainButton;
   }
}

