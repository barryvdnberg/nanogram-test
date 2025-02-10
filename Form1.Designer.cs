namespace Nanogram_test
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
            gridPanel = new TableLayoutPanel();
            pnlRowClues = new Panel();
            pnlColumnClues = new Panel();
            gridPanel.SuspendLayout();
            pnlRowClues.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel
            // 
            gridPanel.AutoSize = true;
            gridPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            gridPanel.Dock = DockStyle.Fill;
            gridPanel.Location = new Point(0, 0);
            gridPanel.Name = "gridPanel";
            gridPanel.Padding = new Padding(20, 20, 0, 0);
            gridPanel.Size = new Size(800, 450);
            gridPanel.TabIndex = 0;
            // 
            // pnlRowClues
            // 
            pnlRowClues.Dock = DockStyle.Left;
            pnlRowClues.Width = 50;
            pnlRowClues.BackColor = Color.Yellow;
            pnlRowClues.Name = "pnlRowClues";
            // 
            // pnlColumnClues
            // 
            pnlColumnClues.Dock = DockStyle.Top;
            pnlColumnClues.Height = 50;
            pnlColumnClues.BackColor = Color.Blue;
            pnlColumnClues.Name = "pnlColumnClues";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridPanel);
            Name = "Form1";
            Text = "Form1";
            gridPanel.ResumeLayout(false);
            pnlRowClues.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel gridPanel;
        private Panel pnlRowClues;
        private Panel pnlColumnClues;
    }
}
