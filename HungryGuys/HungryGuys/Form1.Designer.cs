namespace HungryGuys
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
            this.makeJoeSandwich = new System.Windows.Forms.Button();
            this.bobEatSandwich1 = new System.Windows.Forms.Button();
            this.bobEatSandwich2 = new System.Windows.Forms.Button();
            this.makeBobSandwich = new System.Windows.Forms.Button();
            this.joeEatSandwich1 = new System.Windows.Forms.Button();
            this.joeEatSandwich2 = new System.Windows.Forms.Button();
            this.joesPlateLabel = new System.Windows.Forms.Label();
            this.bobsPlateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeJoeSandwich
            // 
            this.makeJoeSandwich.Location = new System.Drawing.Point(24, 95);
            this.makeJoeSandwich.Name = "makeJoeSandwich";
            this.makeJoeSandwich.Size = new System.Drawing.Size(100, 50);
            this.makeJoeSandwich.TabIndex = 0;
            this.makeJoeSandwich.Text = "Make Joe a sandwich";
            this.makeJoeSandwich.UseVisualStyleBackColor = true;
            this.makeJoeSandwich.Click += new System.EventHandler(this.makeJoeSandwich_Click);
            // 
            // bobEatSandwich1
            // 
            this.bobEatSandwich1.Enabled = false;
            this.bobEatSandwich1.Location = new System.Drawing.Point(24, 151);
            this.bobEatSandwich1.Name = "bobEatSandwich1";
            this.bobEatSandwich1.Size = new System.Drawing.Size(100, 50);
            this.bobEatSandwich1.TabIndex = 1;
            this.bobEatSandwich1.Text = "Eat";
            this.bobEatSandwich1.UseVisualStyleBackColor = true;
            this.bobEatSandwich1.Click += new System.EventHandler(this.bobEatSandwich1_Click);
            // 
            // bobEatSandwich2
            // 
            this.bobEatSandwich2.Enabled = false;
            this.bobEatSandwich2.Location = new System.Drawing.Point(24, 207);
            this.bobEatSandwich2.Name = "bobEatSandwich2";
            this.bobEatSandwich2.Size = new System.Drawing.Size(100, 50);
            this.bobEatSandwich2.TabIndex = 2;
            this.bobEatSandwich2.Text = "Eat";
            this.bobEatSandwich2.UseVisualStyleBackColor = true;
            this.bobEatSandwich2.Click += new System.EventHandler(this.bobEatSandwich2_Click);
            // 
            // makeBobSandwich
            // 
            this.makeBobSandwich.Location = new System.Drawing.Point(144, 95);
            this.makeBobSandwich.Name = "makeBobSandwich";
            this.makeBobSandwich.Size = new System.Drawing.Size(100, 50);
            this.makeBobSandwich.TabIndex = 3;
            this.makeBobSandwich.Text = "Make Bob a sandwich";
            this.makeBobSandwich.UseVisualStyleBackColor = true;
            this.makeBobSandwich.Click += new System.EventHandler(this.makeBobSandwich_Click);
            // 
            // joeEatSandwich1
            // 
            this.joeEatSandwich1.Enabled = false;
            this.joeEatSandwich1.Location = new System.Drawing.Point(144, 151);
            this.joeEatSandwich1.Name = "joeEatSandwich1";
            this.joeEatSandwich1.Size = new System.Drawing.Size(100, 50);
            this.joeEatSandwich1.TabIndex = 4;
            this.joeEatSandwich1.Text = "Eat";
            this.joeEatSandwich1.UseVisualStyleBackColor = true;
            this.joeEatSandwich1.Click += new System.EventHandler(this.joeEatSandwich1_Click);
            // 
            // joeEatSandwich2
            // 
            this.joeEatSandwich2.Enabled = false;
            this.joeEatSandwich2.Location = new System.Drawing.Point(144, 207);
            this.joeEatSandwich2.Name = "joeEatSandwich2";
            this.joeEatSandwich2.Size = new System.Drawing.Size(100, 50);
            this.joeEatSandwich2.TabIndex = 5;
            this.joeEatSandwich2.Text = "Eat";
            this.joeEatSandwich2.UseVisualStyleBackColor = true;
            this.joeEatSandwich2.Click += new System.EventHandler(this.joeEatSandwich2_Click);
            // 
            // joesPlateLabel
            // 
            this.joesPlateLabel.Location = new System.Drawing.Point(21, 22);
            this.joesPlateLabel.Name = "joesPlateLabel";
            this.joesPlateLabel.Size = new System.Drawing.Size(223, 26);
            this.joesPlateLabel.TabIndex = 6;
            // 
            // bobsPlateLabel
            // 
            this.bobsPlateLabel.Location = new System.Drawing.Point(21, 56);
            this.bobsPlateLabel.Name = "bobsPlateLabel";
            this.bobsPlateLabel.Size = new System.Drawing.Size(223, 26);
            this.bobsPlateLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 284);
            this.Controls.Add(this.bobsPlateLabel);
            this.Controls.Add(this.joesPlateLabel);
            this.Controls.Add(this.joeEatSandwich2);
            this.Controls.Add(this.joeEatSandwich1);
            this.Controls.Add(this.makeBobSandwich);
            this.Controls.Add(this.bobEatSandwich2);
            this.Controls.Add(this.bobEatSandwich1);
            this.Controls.Add(this.makeJoeSandwich);
            this.Name = "Form1";
            this.Text = "Hungry Guys";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeJoeSandwich;
        private System.Windows.Forms.Button bobEatSandwich1;
        private System.Windows.Forms.Button bobEatSandwich2;
        private System.Windows.Forms.Button makeBobSandwich;
        private System.Windows.Forms.Button joeEatSandwich1;
        private System.Windows.Forms.Button joeEatSandwich2;
        private System.Windows.Forms.Label joesPlateLabel;
        private System.Windows.Forms.Label bobsPlateLabel;
    }
}

