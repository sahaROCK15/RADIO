
namespace radio
{
    partial class FormRadio
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadio));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.flowLayoutPanelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.buttonRollUp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 52);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(219, 175);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // flowLayoutPanelRadio
            // 
            this.flowLayoutPanelRadio.AutoScroll = true;
            this.flowLayoutPanelRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelRadio.Location = new System.Drawing.Point(237, 52);
            this.flowLayoutPanelRadio.Name = "flowLayoutPanelRadio";
            this.flowLayoutPanelRadio.Size = new System.Drawing.Size(205, 243);
            this.flowLayoutPanelRadio.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.buttonRollUp);
            this.panel.Controls.Add(this.buttonClose);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(447, 25);
            this.panel.TabIndex = 2;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, -1);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(170, 31);
            this.label.TabIndex = 2;
            this.label.Text = "Online Radio";
            // 
            // buttonRollUp
            // 
            this.buttonRollUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRollUp.BackgroundImage = global::radio.Properties.Resources._211863_minus_round_icon;
            this.buttonRollUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRollUp.FlatAppearance.BorderSize = 0;
            this.buttonRollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollUp.Location = new System.Drawing.Point(384, -1);
            this.buttonRollUp.Name = "buttonRollUp";
            this.buttonRollUp.Size = new System.Drawing.Size(26, 26);
            this.buttonRollUp.TabIndex = 1;
            this.buttonRollUp.UseVisualStyleBackColor = false;
            this.buttonRollUp.Click += new System.EventHandler(this.buttonRollUp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClose.BackgroundImage = global::radio.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(416, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 26);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 307);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flowLayoutPanelRadio);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRadio";
            this.Text = "Online Radio";
            this.Load += new System.EventHandler(this.FormRadio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRadio;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRollUp;
        private System.Windows.Forms.Label label;
    }
}

