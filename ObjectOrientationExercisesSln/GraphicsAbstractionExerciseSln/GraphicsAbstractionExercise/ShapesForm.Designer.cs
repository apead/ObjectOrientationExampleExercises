namespace GraphicsAbstractionExercise
{
    partial class ShapesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cyanPanel = new System.Windows.Forms.Panel();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.triangleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.shapesListbox = new System.Windows.Forms.ListBox();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scaleBar);
            this.panel1.Controls.Add(this.cyanPanel);
            this.panel1.Controls.Add(this.bluePanel);
            this.panel1.Controls.Add(this.greenPanel);
            this.panel1.Controls.Add(this.redPanel);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.squareButton);
            this.panel1.Controls.Add(this.circleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // cyanPanel
            // 
            this.cyanPanel.BackColor = System.Drawing.Color.Cyan;
            this.cyanPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cyanPanel.Location = new System.Drawing.Point(465, 0);
            this.cyanPanel.Name = "cyanPanel";
            this.cyanPanel.Size = new System.Drawing.Size(55, 44);
            this.cyanPanel.TabIndex = 8;
            // 
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.bluePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bluePanel.Location = new System.Drawing.Point(410, 0);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(55, 44);
            this.bluePanel.TabIndex = 7;
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.Color.Green;
            this.greenPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.greenPanel.Location = new System.Drawing.Point(355, 0);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(55, 44);
            this.greenPanel.TabIndex = 6;
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.redPanel.Location = new System.Drawing.Point(300, 0);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(55, 44);
            this.redPanel.TabIndex = 4;
            // 
            // triangleButton
            // 
            this.triangleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.triangleButton.Location = new System.Drawing.Point(225, 0);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(75, 44);
            this.triangleButton.TabIndex = 3;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.rectangleButton.Location = new System.Drawing.Point(150, 0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(75, 44);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.squareButton.Location = new System.Drawing.Point(75, 0);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 44);
            this.squareButton.TabIndex = 1;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.circleButton.Location = new System.Drawing.Point(0, 0);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 44);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // shapesListbox
            // 
            this.shapesListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.shapesListbox.FormattingEnabled = true;
            this.shapesListbox.Location = new System.Drawing.Point(680, 0);
            this.shapesListbox.Name = "shapesListbox";
            this.shapesListbox.Size = new System.Drawing.Size(120, 406);
            this.shapesListbox.TabIndex = 1;
            // 
            // scaleBar
            // 
            this.scaleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleBar.Location = new System.Drawing.Point(520, 0);
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(280, 44);
            this.scaleBar.TabIndex = 9;
            // 
            // ShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapesListbox);
            this.Controls.Add(this.panel1);
            this.Name = "ShapesForm";
            this.Text = "ShapesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.ListBox shapesListbox;
        private System.Windows.Forms.Panel cyanPanel;
        private System.Windows.Forms.Panel bluePanel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.TrackBar scaleBar;
    }
}