namespace Kolman_CourseProject_Part1
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(35, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(74, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(131, 40);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(339, 38);
            this.titleText.TabIndex = 1;
            this.titleText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(131, 271);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(339, 38);
            this.urlText.TabIndex = 5;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(35, 274);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(84, 31);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL: ";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(131, 210);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(339, 38);
            this.yearText.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yearLabel.Location = new System.Drawing.Point(35, 213);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(79, 31);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            this.yearLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(131, 152);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(339, 38);
            this.genreText.TabIndex = 3;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(35, 155);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(97, 31);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(131, 94);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(339, 38);
            this.artistText.TabIndex = 2;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(35, 97);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(85, 31);
            this.artistLabel.TabIndex = 8;
            this.artistLabel.Text = "Artist:";
            this.artistLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(131, 364);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(195, 93);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(569, 40);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(567, 560);
            this.outputText.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 663);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox outputText;
    }
}

