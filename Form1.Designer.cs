
namespace Map_Project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txtBoxLat = new System.Windows.Forms.TextBox();
            this.txtBoxLon = new System.Windows.Forms.TextBox();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.picBoxHud = new System.Windows.Forms.PictureBox();
            this.txtBoxRoll = new System.Windows.Forms.TextBox();
            this.txtBoxPitch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHud)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(454, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(671, 594);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // txtBoxLat
            // 
            this.txtBoxLat.Location = new System.Drawing.Point(348, 422);
            this.txtBoxLat.Name = "txtBoxLat";
            this.txtBoxLat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLat.TabIndex = 1;
            // 
            // txtBoxLon
            // 
            this.txtBoxLon.Location = new System.Drawing.Point(348, 469);
            this.txtBoxLon.Name = "txtBoxLon";
            this.txtBoxLon.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLon.TabIndex = 2;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(348, 520);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(95, 23);
            this.btnLoadMap.TabIndex = 3;
            this.btnLoadMap.Text = "Haritayı Yükle";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // picBoxHud
            // 
            this.picBoxHud.Location = new System.Drawing.Point(12, 12);
            this.picBoxHud.Name = "picBoxHud";
            this.picBoxHud.Size = new System.Drawing.Size(421, 279);
            this.picBoxHud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHud.TabIndex = 5;
            this.picBoxHud.TabStop = false;
            this.picBoxHud.Click += new System.EventHandler(this.picBoxHud_Click);
            // 
            // txtBoxRoll
            // 
            this.txtBoxRoll.Location = new System.Drawing.Point(151, 452);
            this.txtBoxRoll.Name = "txtBoxRoll";
            this.txtBoxRoll.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRoll.TabIndex = 6;
            this.txtBoxRoll.TextChanged += new System.EventHandler(this.txtBoxRoll_TextChanged);
            // 
            // txtBoxPitch
            // 
            this.txtBoxPitch.Location = new System.Drawing.Point(29, 452);
            this.txtBoxPitch.Name = "txtBoxPitch";
            this.txtBoxPitch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPitch.TabIndex = 7;
            this.txtBoxPitch.TextChanged += new System.EventHandler(this.txtBoxPitch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPitch);
            this.Controls.Add(this.txtBoxRoll);
            this.Controls.Add(this.picBoxHud);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.txtBoxLon);
            this.Controls.Add(this.txtBoxLat);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox txtBoxLat;
        private System.Windows.Forms.TextBox txtBoxLon;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.PictureBox picBoxHud;
        private System.Windows.Forms.TextBox txtBoxRoll;
        private System.Windows.Forms.TextBox txtBoxPitch;
        private System.Windows.Forms.Label label1;
    }
}

