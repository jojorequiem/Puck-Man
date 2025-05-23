﻿namespace Puck_Man_Game.src.PuckMan.UI.Screens
{
    partial class FrmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.BtnModeHistoire = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnModeInfini = new System.Windows.Forms.Button();
            this.lblTitreMenuPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnModeHistoire
            // 
            this.BtnModeHistoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModeHistoire.ForeColor = System.Drawing.Color.Black;
            this.BtnModeHistoire.Location = new System.Drawing.Point(91, 313);
            this.BtnModeHistoire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModeHistoire.Name = "BtnModeHistoire";
            this.BtnModeHistoire.Size = new System.Drawing.Size(700, 69);
            this.BtnModeHistoire.TabIndex = 1;
            this.BtnModeHistoire.Text = "MODE HISTOIRE";
            this.BtnModeHistoire.UseVisualStyleBackColor = true;
            this.BtnModeHistoire.Click += new System.EventHandler(this.BtnModeHistoire_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.ForeColor = System.Drawing.Color.Black;
            this.BtnRetour.Location = new System.Drawing.Point(91, 422);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(700, 69);
            this.BtnRetour.TabIndex = 2;
            this.BtnRetour.Text = "RETOUR";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // BtnModeInfini
            // 
            this.BtnModeInfini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModeInfini.ForeColor = System.Drawing.Color.Black;
            this.BtnModeInfini.Location = new System.Drawing.Point(91, 204);
            this.BtnModeInfini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModeInfini.Name = "BtnModeInfini";
            this.BtnModeInfini.Size = new System.Drawing.Size(700, 69);
            this.BtnModeInfini.TabIndex = 0;
            this.BtnModeInfini.Text = "MODE INFINI";
            this.BtnModeInfini.UseVisualStyleBackColor = true;
            this.BtnModeInfini.Click += new System.EventHandler(this.BtnModeInfini_Click);
            // 
            // lblTitreMenuPrincipal
            // 
            this.lblTitreMenuPrincipal.BackColor = System.Drawing.Color.Black;
            this.lblTitreMenuPrincipal.Font = new System.Drawing.Font("Minecraft", 48.20869F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitreMenuPrincipal.Location = new System.Drawing.Point(91, 45);
            this.lblTitreMenuPrincipal.Name = "lblTitreMenuPrincipal";
            this.lblTitreMenuPrincipal.Size = new System.Drawing.Size(700, 94);
            this.lblTitreMenuPrincipal.TabIndex = 15;
            this.lblTitreMenuPrincipal.Text = "JOUER";
            this.lblTitreMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 604);
            this.Controls.Add(this.lblTitreMenuPrincipal);
            this.Controls.Add(this.BtnModeHistoire);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.BtnModeInfini);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(901, 651);
            this.MinimumSize = new System.Drawing.Size(899, 649);
            this.Name = "FrmPlay";
            this.Text = "Puck-Man - Jouer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModeInfini;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnModeHistoire;
        private System.Windows.Forms.Label lblTitreMenuPrincipal;
    }
} 