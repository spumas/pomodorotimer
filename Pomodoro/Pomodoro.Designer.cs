namespace Pomodoro
{
    partial class Pomodoro
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.btnStart = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.BackColor = System.Drawing.Color.Tomato;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ShortcutsEnabled = false;
            this.txtResult.TabStop = false;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Pomodoro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Pomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResult;
    }
}

