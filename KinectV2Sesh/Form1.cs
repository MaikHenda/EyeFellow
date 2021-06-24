using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;

namespace KinectV2Sesh
{
    public partial class Form1 : Form
    {
        KinectSensor kinectSensor = null;
        BodyFrameReader bodyFrameReader = null;
        Body[] bodies = null;

        //Eye related
        private Timer tmr;
        private int PupilRadius = 80;
        private int EyeBallRadius = 500;
        private int DistanceBetweenEyes = -50;

        public Form1()
        {
            InitializeComponent();
            Cursor.Hide();
            this.pictureBox1.Paint += pictureBox1_Paint;

            tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += tmr_Tick;
            tmr.Start();

            InitialiseKinect();
        }

        public void InitialiseKinect()
        {
            kinectSensor = KinectSensor.GetDefault();

            if (kinectSensor != null)
            {
                //Turn On Kinect
                kinectSensor.Open();
            
            }

            bodyFrameReader = kinectSensor.BodyFrameSource.OpenReader();

            if(bodyFrameReader != null)
            {
                bodyFrameReader.FrameArrived += Reader_FrameArrived;
            }
        }

        private void Reader_FrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
            //Scanning for Bodies in the Kinect Range
            bool dataReceived = false;

            using (BodyFrame bodyFrame = e.FrameReference.AcquireFrame())
            {
                if(bodyFrame != null)
                {
                   if (bodies == null)
                    {
                        bodies = new Body[bodyFrame.BodyCount];
                    }
                    bodyFrame.GetAndRefreshBodyData(bodies);
                    dataReceived = true;
                }
            }
            
            //If a body is detected, the tracking of the specific joint starts.
            if (dataReceived)
            {
                foreach (Body body in bodies)
                {
                    if (body.IsTracked)
                    {
                        IReadOnlyDictionary<JointType, Joint> joints = body.Joints;
                        Dictionary<JointType, Point> jointPoints = new Dictionary<JointType, Point>();

                        //Joint MidSpine is selected
                        Joint midSpine = joints[JointType.SpineMid];

                        //Collecting the data of each position of the MidSpine
                        float ms_distance_x = midSpine.Position.X;
                        float ms_distance_y = midSpine.Position.Y;
                        float ms_distance_z = midSpine.Position.Z;

                        float distanceX = (ms_distance_x + 1) * 960;

                        //Setting a constant Y value, considering the shocks in the eye for every step set.
                        float distanceY = 580;

                        txtMidSpineX.Text = ms_distance_x.ToString("#.##");
                        txtMidSpineY.Text = ms_distance_y.ToString("#.##");
                        txtMidSpineZ.Text = ms_distance_z.ToString("#.##");

                        tbDisX.Text = distanceX.ToString();


                        Cursor.Position = new Point((int)distanceX, (int)distanceY);

                    }
                }
            }
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Setting the visual radius of the eye
            Point center = new Point((int)(pictureBox1.ClientSize.Width / 1.1450), pictureBox1.ClientSize.Height / 2);
            Point LeftEyeCenter = new Point(center.X - EyeBallRadius - (DistanceBetweenEyes / 1), center.Y);


            Rectangle rc = new Rectangle(LeftEyeCenter, new Size(1, 1));
            rc.Inflate(EyeBallRadius, EyeBallRadius);
            //e.Graphics.DrawEllipse(Pens.Black, rc);

            //Creating the pupil of the Eye
            Point curPos = pictureBox1.PointToClient(Cursor.Position);
            Double DistanceFromLeftEyeToCursor = getDistance(LeftEyeCenter.X, LeftEyeCenter.Y, curPos.X, curPos.Y);
            double angleLeft = getAngleInDegrees(LeftEyeCenter.X, LeftEyeCenter.Y, curPos.X, curPos.Y);

            rc = new Rectangle(new Point(Math.Min((int)DistanceFromLeftEyeToCursor, EyeBallRadius - PupilRadius), 0), new Size(1, 1));

            rc.Inflate(PupilRadius, PupilRadius);
            e.Graphics.TranslateTransform(LeftEyeCenter.X, LeftEyeCenter.Y);
            e.Graphics.RotateTransform((float)angleLeft);
            e.Graphics.FillEllipse(Brushes.Black, rc);
        }

        private Double getDistance(int Ax, int Ay, int Bx, int By)
        {
            return Math.Sqrt(Math.Pow((Double)Ax - Bx, 2) + Math.Pow((Double)Ay - By, 2));
        }

        private Double getAngleInDegrees(int cx, int cy, int X, int Y)
        {
            // draw a line from the center of the circle
            // to the where the cursor is...
            // If the line points:
            // up = 0 degrees
            // right = 90 degrees
            // down = 180 degrees
            // left = 270 degrees

            Double angle;
            int dy = Y - cy;
            int dx = X - cx;
            if (dx == 0) // Straight up and down | avoid divide by zero error!
            {
                if (dy <= 0)
                {
                    angle = 0;
                }
                else
                {
                    angle = 180;
                }
            }
            else
            {
                angle = Math.Atan((Double)dy / (Double)dx);
                angle = angle * ((Double)180 / Math.PI);

                if (X <= cx)
                {
                    angle = 180 + angle;
                }
            }

            return angle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

