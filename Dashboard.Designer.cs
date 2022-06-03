namespace CafeManagementSystem
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnRI = new Guna.UI2.WinForms.Guna2Button();
            this.btnUI = new Guna.UI2.WinForms.Guna2Button();
            this.btnAI = new Guna.UI2.WinForms.Guna2Button();
            this.btnPO = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_RemoveItem1 = new CafeManagementSystem.AllUserControls.UC_RemoveItem();
            this.uC_UpdateItems1 = new CafeManagementSystem.AllUserControls.UC_UpdateItems();
            this.uC_PlaceOrder1 = new CafeManagementSystem.AllUserControls.UC_PlaceOrder();
            this.uC_AddItems1 = new CafeManagementSystem.AllUserControls.UC_AddItems();
            this.uC_Welcome1 = new CafeManagementSystem.AllUserControls.UC_Welcome();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRI);
            this.panel1.Controls.Add(this.btnUI);
            this.panel1.Controls.Add(this.btnAI);
            this.panel1.Controls.Add(this.btnPO);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(66, 490);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(74, 24);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRI
            // 
            this.btnRI.BorderRadius = 12;
            this.btnRI.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRI.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRI.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRI.CheckedState.Parent = this.btnRI;
            this.btnRI.CustomImages.Parent = this.btnRI;
            this.guna2Transition1.SetDecoration(this.btnRI, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRI.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRI.ForeColor = System.Drawing.Color.White;
            this.btnRI.HoverState.Parent = this.btnRI;
            this.btnRI.Location = new System.Drawing.Point(22, 235);
            this.btnRI.Name = "btnRI";
            this.btnRI.ShadowDecoration.Parent = this.btnRI;
            this.btnRI.Size = new System.Drawing.Size(202, 41);
            this.btnRI.TabIndex = 0;
            this.btnRI.Text = "Remove Items";
            this.btnRI.Click += new System.EventHandler(this.btnRI_Click);
            // 
            // btnUI
            // 
            this.btnUI.BorderRadius = 12;
            this.btnUI.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUI.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUI.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUI.CheckedState.Parent = this.btnUI;
            this.btnUI.CustomImages.Parent = this.btnUI;
            this.guna2Transition1.SetDecoration(this.btnUI, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUI.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUI.ForeColor = System.Drawing.Color.White;
            this.btnUI.HoverState.Parent = this.btnUI;
            this.btnUI.Location = new System.Drawing.Point(22, 171);
            this.btnUI.Name = "btnUI";
            this.btnUI.ShadowDecoration.Parent = this.btnUI;
            this.btnUI.Size = new System.Drawing.Size(202, 41);
            this.btnUI.TabIndex = 0;
            this.btnUI.Text = "Upload Items";
            this.btnUI.Click += new System.EventHandler(this.btnUI_Click);
            // 
            // btnAI
            // 
            this.btnAI.BorderRadius = 12;
            this.btnAI.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAI.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAI.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAI.CheckedState.Parent = this.btnAI;
            this.btnAI.CustomImages.Parent = this.btnAI;
            this.guna2Transition1.SetDecoration(this.btnAI, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAI.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAI.ForeColor = System.Drawing.Color.White;
            this.btnAI.HoverState.Parent = this.btnAI;
            this.btnAI.Location = new System.Drawing.Point(22, 107);
            this.btnAI.Name = "btnAI";
            this.btnAI.ShadowDecoration.Parent = this.btnAI;
            this.btnAI.Size = new System.Drawing.Size(202, 41);
            this.btnAI.TabIndex = 0;
            this.btnAI.Text = "Add Items";
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // btnPO
            // 
            this.btnPO.BorderRadius = 12;
            this.btnPO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPO.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPO.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPO.CheckedState.Parent = this.btnPO;
            this.btnPO.CustomImages.Parent = this.btnPO;
            this.guna2Transition1.SetDecoration(this.btnPO, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPO.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPO.ForeColor = System.Drawing.Color.White;
            this.btnPO.HoverState.Parent = this.btnPO;
            this.btnPO.Location = new System.Drawing.Point(22, 44);
            this.btnPO.Name = "btnPO";
            this.btnPO.ShadowDecoration.Parent = this.btnPO;
            this.btnPO.Size = new System.Drawing.Size(202, 41);
            this.btnPO.TabIndex = 0;
            this.btnPO.Text = "Place Order";
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItem1.TabIndex = 4;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(781, 514);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_AddItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRI;
        private Guna.UI2.WinForms.Guna2Button btnUI;
        private Guna.UI2.WinForms.Guna2Button btnAI;
        private Guna.UI2.WinForms.Guna2Button btnPO;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
    }
}