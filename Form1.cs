using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace Map_Project
{
    public partial class Form1 : Form
    {
        const string apiKey = "**********************************";
        const float hudCameraViewAngle = 180;
        const float horizonLength = 50;
        const int t = 2;
        float pitch = 0;
        float roll = 0;
        Image img = new Bitmap(1, 1);
        GMapOverlay markers = new GMapOverlay("markers");
        public Form1()
        {
            GMapProviders.GoogleMap.ApiKey = apiKey;
            InitializeComponent();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtBoxLat.Text);
            double lon = Convert.ToDouble(txtBoxLon.Text);
            map.MinZoom = 5;
            map.MaxZoom = 18;
            map.Zoom = 10;
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            map.Position = new GMap.NET.PointLatLng(lat, lon);

            PointLatLng point = new PointLatLng(lat, lon);

            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.orange_small);

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);

        }
        private Image Rotate_Image(Image image, float angle)
        {

            Bitmap img = new Bitmap(image.Width, image.Height);

            Graphics gfx = Graphics.FromImage(img);

            gfx.TranslateTransform(img.Width / 2, img.Height / 2);

            gfx.RotateTransform(angle);

            gfx.DrawImage(image, -img.Width, -img.Height, image.Width*t, image.Height*t);

            gfx.Dispose();

            return img;

        }
        private Image DrawHUD(PictureBox picBox, float angle)
        {
            float h = picBox.Size.Height;
            float w = picBox.Size.Width;
            Bitmap img = new Bitmap((int)w, (int)h);
            Graphics gfx = Graphics.FromImage(img);


            if (angle < hudCameraViewAngle / 2 && angle > -hudCameraViewAngle / 2)
            {
                float ratio = (hudCameraViewAngle*(t-1)/2 + hudCameraViewAngle / 2 - angle) / (hudCameraViewAngle*(t-1)/ 2 + (hudCameraViewAngle / 2 + angle));//MathF.Tan(hudCameraViewAngle - angle) / MathF.Tan(hudCameraViewAngle + angle);
                float sky_h = h / (1 / ratio + 1);
                float grnd_h = h / (ratio + 1);



                RectangleF sky = new RectangleF(0, 0, w, sky_h);
                RectangleF grnd = new RectangleF(0, sky_h, w, grnd_h);

                gfx.FillRectangle(Brushes.Aqua, sky);
                gfx.FillRectangle(Brushes.Brown, grnd);
            }
            else if (angle <= -hudCameraViewAngle / 2)
            {
                RectangleF sky = new RectangleF(0, 0, w, h);
                gfx.FillRectangle(Brushes.Aqua, sky);
            }
            else if (angle >= hudCameraViewAngle / 2)
            {
                RectangleF grnd = new RectangleF(0, 0, w, h);
                gfx.FillRectangle(Brushes.Brown, grnd);
            }
            gfx.DrawImage(img, 0, 0, (int)w, (int)h);
            gfx.DrawLine(Pens.Red, w/2 -horizonLength/2, h / 2, w/2 + horizonLength/2, h / 2);
            gfx.DrawString("0", DefaultFont, Brushes.Red, w / 2 + horizonLength / 2, h / 2);
            gfx.Dispose();

            return img;
        }

        private void txtBoxRoll_TextChanged(object sender, EventArgs e)
        {
            if(float.TryParse(txtBoxRoll.Text, out roll))
            {
                roll = (float)Convert.ToDouble(txtBoxRoll.Text);
                img = DrawHUD(picBoxHud, pitch);
                picBoxHud.BackgroundImage = Rotate_Image(img, roll);
            }
        }

        private void txtBoxPitch_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtBoxPitch.Text, out pitch))
            {
                pitch = (float)Convert.ToDouble(txtBoxPitch.Text);
                img = DrawHUD(picBoxHud, pitch);
                picBoxHud.BackgroundImage = Rotate_Image(img, roll);
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.orange_small);
                markers.Markers.Add(marker);




            }
        }

        private void picBoxHud_Click(object sender, EventArgs e)
        {

        }
    }
}
