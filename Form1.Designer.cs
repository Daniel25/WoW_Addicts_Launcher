
namespace Launcher_WoW_Addicts
{
    partial class Form_wow_addicts
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_wow_addicts));
            this.Button_play = new System.Windows.Forms.Button();
            this.Button_browse = new System.Windows.Forms.Button();
            this.Label_close = new System.Windows.Forms.Label();
            this.PictureBox_logo = new System.Windows.Forms.PictureBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label_ready = new System.Windows.Forms.Label();
            this.Button_update = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_play
            // 
            this.Button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_play.BackgroundImage")));
            this.Button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_play.Location = new System.Drawing.Point(623, 383);
            this.Button_play.Name = "Button_play";
            this.Button_play.Size = new System.Drawing.Size(142, 44);
            this.Button_play.TabIndex = 0;
            this.Button_play.Text = "Play";
            this.Button_play.UseVisualStyleBackColor = true;
            this.Button_play.Click += new System.EventHandler(this.Button_play_Click);
            // 
            // Button_browse
            // 
            this.Button_browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_browse.BackgroundImage")));
            this.Button_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_browse.Location = new System.Drawing.Point(461, 383);
            this.Button_browse.Name = "Button_browse";
            this.Button_browse.Size = new System.Drawing.Size(142, 44);
            this.Button_browse.TabIndex = 1;
            this.Button_browse.Text = "Browse";
            this.Button_browse.UseVisualStyleBackColor = true;
            this.Button_browse.Click += new System.EventHandler(this.Button_browse_Click);
            // 
            // Label_close
            // 
            this.Label_close.AutoSize = true;
            this.Label_close.BackColor = System.Drawing.Color.Transparent;
            this.Label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_close.ForeColor = System.Drawing.Color.Green;
            this.Label_close.Location = new System.Drawing.Point(754, 22);
            this.Label_close.Name = "Label_close";
            this.Label_close.Size = new System.Drawing.Size(21, 20);
            this.Label_close.TabIndex = 2;
            this.Label_close.Text = "X";
            this.Label_close.Click += new System.EventHandler(this.Label_close_Click);
            // 
            // PictureBox_logo
            // 
            this.PictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_logo.BackgroundImage")));
            this.PictureBox_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_logo.Location = new System.Drawing.Point(22, 22);
            this.PictureBox_logo.Name = "PictureBox_logo";
            this.PictureBox_logo.Size = new System.Drawing.Size(245, 74);
            this.PictureBox_logo.TabIndex = 3;
            this.PictureBox_logo.TabStop = false;
            this.PictureBox_logo.Click += new System.EventHandler(this.PictureBox_logo_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(36, 397);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(245, 23);
            this.ProgressBar1.TabIndex = 4;
            // 
            // Label_ready
            // 
            this.Label_ready.AutoSize = true;
            this.Label_ready.BackColor = System.Drawing.Color.Transparent;
            this.Label_ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ready.ForeColor = System.Drawing.Color.Green;
            this.Label_ready.Location = new System.Drawing.Point(33, 378);
            this.Label_ready.Name = "Label_ready";
            this.Label_ready.Size = new System.Drawing.Size(54, 16);
            this.Label_ready.TabIndex = 5;
            this.Label_ready.Text = "Ready";
            // 
            // Button_update
            // 
            this.Button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_update.BackgroundImage")));
            this.Button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_update.Location = new System.Drawing.Point(297, 383);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(142, 44);
            this.Button_update.TabIndex = 6;
            this.Button_update.Text = "Update";
            this.Button_update.UseVisualStyleBackColor = true;
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.ForeColor = System.Drawing.Color.Green;
            this.label_version.Location = new System.Drawing.Point(717, 22);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(31, 20);
            this.label_version.TabIndex = 7;
            this.label_version.Text = "V2";
            // 
            // Form_wow_addicts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Label_ready);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.PictureBox_logo);
            this.Controls.Add(this.Label_close);
            this.Controls.Add(this.Button_browse);
            this.Controls.Add(this.Button_play);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_wow_addicts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoW_Addicts";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_wow_addicts_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_play;
        private System.Windows.Forms.Button Button_browse;
        private System.Windows.Forms.Label Label_close;
        private System.Windows.Forms.PictureBox PictureBox_logo;
        private System.Windows.Forms.Label Label_ready;
        private System.Windows.Forms.Button Button_update;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label label_version;
    }
}

